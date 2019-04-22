using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;

namespace SemPraceMain
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Grid VykreslovaniGridHlavni;
        Canvas VykreslovaniCanvasHlavni;

        List <HerniObjekt> seznamHernichObjektu;
        DispatcherTimer casovac;

        double maxVelikostCanvasX;
        double maxVelikostCanvasY;

        public MainWindow()
        {
            InitializeComponent();

            this.SizeChanged += OnWindowSizeChanged;

            Application.Current.MainWindow.Width = 1000;
            Application.Current.MainWindow.Height = 600;

            VykreslovaniGridHlavni = new Grid();
            VykreslovaniGridHlavni.Width = hlavniOkno.Width;
            VykreslovaniGridHlavni.Height = hlavniOkno.Height;

            VykreslovaniCanvasHlavni = new Canvas();
            VykreslovaniCanvasHlavni.Width = VykreslovaniGridHlavni.Width;
            VykreslovaniCanvasHlavni.Height = VykreslovaniGridHlavni.Height;
            VykreslovaniCanvasHlavni.Background = Brushes.Black;

            hlavniOkno.Content = VykreslovaniGridHlavni;
            VykreslovaniGridHlavni.Children.Add(VykreslovaniCanvasHlavni);

            seznamHernichObjektu = new List<HerniObjekt>();
            //casovac.Tick += new EventHandler(Casovac_Tick);
            //casovac.Interval = new TimeSpan(0, 0, 0, 0, 20);
            //casovac.Start();

            maxVelikostCanvasX = VykreslovaniCanvasHlavni.Width;
            maxVelikostCanvasY = VykreslovaniCanvasHlavni.Height;
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
            for (int pocetPlanet = 0; pocetPlanet < 5; pocetPlanet++)
            {
                Planeta novaPlaneta = new Planeta(maxVelikostCanvasX, maxVelikostCanvasY, seznamHernichObjektu);
                seznamHernichObjektu.Add(novaPlaneta);
            }
            
            VykreslovaniObjektu kresleniObjektu = new VykreslovaniObjektu();
            foreach (var vesmirnyObjekt in seznamHernichObjektu)
            {
                var objektKeKresleni = kresleniObjektu.NakresliVesmirnyObjekt(vesmirnyObjekt);
                VykreslovaniCanvasHlavni.Children.Add(objektKeKresleni);
                Canvas.SetLeft(objektKeKresleni, (vesmirnyObjekt.PoziceX - vesmirnyObjekt.VelikostPolomer + 3 ));
                Canvas.SetTop(objektKeKresleni, (vesmirnyObjekt.PoziceY - vesmirnyObjekt.VelikostPolomer + 2 ));
                if (vesmirnyObjekt is Planeta)
                {
                    foreach (var puntikKolem in (vesmirnyObjekt as Planeta).obletoveBodyPlanety)
                    {
                        var obletovyPuntik = kresleniObjektu.NakresliPuntik(puntikKolem, Color.FromArgb(255, 100, 100, 100));
                        VykreslovaniCanvasHlavni.Children.Add(obletovyPuntik);
                        Canvas.SetLeft(obletovyPuntik, puntikKolem.X);
                        Canvas.SetTop(obletovyPuntik, puntikKolem.Y);
                    }
                    foreach (var puntikOkraj in (vesmirnyObjekt as Planeta).kontaktniBodyPlanety)
                    {
                        var obletovyPuntik = kresleniObjektu.NakresliPuntik(puntikOkraj, Color.FromArgb(255, 150, 150, 150));
                        VykreslovaniCanvasHlavni.Children.Add(obletovyPuntik);
                        Canvas.SetLeft(obletovyPuntik, puntikOkraj.X);
                        Canvas.SetTop(obletovyPuntik, puntikOkraj.Y);
                    }
                }
            }
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
