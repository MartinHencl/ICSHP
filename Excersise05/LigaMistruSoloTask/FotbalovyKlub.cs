using System.ComponentModel;

namespace LigaMistruSoloTask
{
    public enum FotbalovyKlub
    {
        [Description("None")]
        NONE = 1,
        [Description("FC Porto")]
        FCPorto = 2,
        [Description("Arsenal")]
        Arsenal = 3,
        [Description("Real Madrid")]
        RealMadrid = 4,
        [Description("Chelsea")]
        Chelsea = 5,
        [Description("Barcelona")]
        Barcelona = 6
    }
    public static class MyEnumExtensions
    {
        public static string ToDescriptionString(this FotbalovyKlub value)
        {
            DescriptionAttribute[] attributes = (DescriptionAttribute[])value
               .GetType()
               .GetField(value.ToString())
               .GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : string.Empty;
        }
    }
}
