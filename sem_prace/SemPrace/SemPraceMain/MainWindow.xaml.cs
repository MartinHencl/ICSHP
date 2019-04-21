using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace SemPraceMain
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Grid VykreaslovaniGridHlavni;
        Canvas VykreslovaniCanvasHlavni;

        List <HerniObjekt> seznamHernichObjektu;
        DispatcherTimer casovac;

        double maxVelikostX;
        double maxVelikostY;

        public MainWindow()
        {
            InitializeComponent();

            this.SizeChanged += OnWindowSizeChanged;

            Application.Current.MainWindow.Width = 1000;
            Application.Current.MainWindow.Height = 600;

            VykreaslovaniGridHlavni = new Grid();
            VykreaslovaniGridHlavni.Width = hlavniOkno.Width;
            VykreaslovaniGridHlavni.Height = hlavniOkno.Height;

            VykreslovaniCanvasHlavni = new Canvas();
            VykreslovaniCanvasHlavni.Width = VykreaslovaniGridHlavni.Width;
            VykreslovaniCanvasHlavni.Height = VykreaslovaniGridHlavni.Height;

            hlavniOkno.Content = VykreaslovaniGridHlavni;
            VykreaslovaniGridHlavni.Children.Add(VykreslovaniCanvasHlavni);

            seznamHernichObjektu = new List<HerniObjekt>();
            //casovac.Tick += new EventHandler(Casovac_Tick);
            //casovac.Interval = new TimeSpan(0, 0, 0, 0, 20);
            //casovac.Start();

            maxVelikostX = VykreslovaniCanvasHlavni.Width;
            maxVelikostY = VykreslovaniCanvasHlavni.Height;
            VygenerovaniNovehoSveta();
        }

        //Při pohybu kurzoru myši zvýrazněte planetu, která se nachází pod kurzorem
        //o Umožňuje pomocí levého tlačítka myši vybrat planetu hráče
        //o Umožňuje pomocí pravého tlačítka myši odeslat stanovené množství jednotek na cílovou planetu
        //o Umožňuje pomocí kolečka myši volit poměr odesílaných jednotek

        private void Casovac_Tick(object sender, EventArgs e)
        {
            // code goes here
        }

        private void CpuNepritele()
        {
            //  který periodicky v náhodných intervalech (300-700 ms) 
            //  odesílá 50 % jednotek z náhodné planety na náhodnou planetu
        }

        private void VygenerovaniNovehoSveta()
        {
            //planety nesmí být umístěny na hraně(nebo za
            //hranou) mapy a nesmí se dotýkat(radius obletové vzdálenosti jednotlivých planet); nageneruje
            //planety různé velikosti(16 - 48), některé hráče, některé neutrální, některé CPU
            //Canvas canvasMuj = new Canvas();
            for (int pocetPlanet = 0; pocetPlanet < 5; pocetPlanet++)
            {
                Planeta novaPlaneta = new Planeta(maxVelikostX, maxVelikostY);
                seznamHernichObjektu.Add(novaPlaneta);
            }
            
            VykreslovaniObjektu kresleniObjektu = new VykreslovaniObjektu();
            foreach (var objekt in seznamHernichObjektu)
            {
                var objektKeKresleni = kresleniObjektu.NakresliNovyObjekt(objekt);
                VykreslovaniCanvasHlavni.Children.Add(objektKeKresleni);
                Canvas.SetLeft(objektKeKresleni, (objekt.PoziceX - objekt.Velikost / 2));
                Canvas.SetTop(objektKeKresleni, (objekt.PoziceY - objekt.Velikost / 2));
            }
            //this.Content = canvasHlavni;
        }

        private void AlgoritmusVypoctuTrasyMeziDvemaPlanetami()
        {
            //1.otestuje, jestli existuje přímá cesta
            //• Spojí každý kontaktní bod 1.planety s každým kontaktním bodem 2.planety
            //• Ověřuje konflikt testovaných cest s jinými planetami
            //• Pokud existuje alespoň jedna nekonfliktní cesta, vybere nejkratší možnou
            //▪ 2.vytvoří obletovou cestu
            //• 1) identifikujte planety v přímé cestě a seřaďte je podle polohy kontaktu
            //• 2) postupně vybudujte trasu
            //o Od výchozí planety(kontaktní bod) k nejbližšímu obletovému bodu první
            //konfliktní planety
            //o Kratší variantu(po / proti směru hodinových ručiček) obletu konfliktní
            //planety
            //o Od posledního bodu(obletový konfliktní p./ kontaktní bod výchozí p.)
            //pokračujte k dalšímu obletovému bodu nebo rovnou k cílovému
            //kontaktnímu bodu
        }

        protected void OnWindowSizeChanged(object sender, SizeChangedEventArgs e)
        {
            double newWindowHeight = e.NewSize.Height;
            double newWindowWidth = e.NewSize.Width;
            double prevWindowHeight = e.PreviousSize.Height;
            double prevWindowWidth = e.PreviousSize.Width;
        }
    }
}
