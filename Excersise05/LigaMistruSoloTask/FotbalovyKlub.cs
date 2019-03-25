using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq;

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

        public static string GetDescription<T>(this T e) where T : IConvertible
        {
            if (e is Enum)
            {
                Type type = e.GetType();
                Array values = System.Enum.GetValues(type);

                foreach (int val in values)
                {
                    if (val == e.ToInt32(CultureInfo.InvariantCulture))
                    {
                        var memInfo = type.GetMember(type.GetEnumName(val));
                        var descriptionAttribute = memInfo[0]
                            .GetCustomAttributes(typeof(DescriptionAttribute), false)
                            .FirstOrDefault() as DescriptionAttribute;

                        if (descriptionAttribute != null)
                        {
                            return descriptionAttribute.Description;
                        }
                    }
                }
            }
            return null; // could also return string.Empty
        }
    }
}
