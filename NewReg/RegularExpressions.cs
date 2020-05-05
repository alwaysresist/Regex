using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace NewReg
{
    public static class RegularExpressions
    {
        public static bool IsIP(this string s)
        {
            Regex reg = new Regex(@"^(((0)|([1-9]\d?)|(1\d\d)|(2[0-5]{2}))\.?){0,3}((0)|([1-9]\d?)|(1\d\d)|(2[0-5]{2}))?$");
            return reg.IsMatch(s);
        }

        public static bool IsGUID(this string s)
        {
            Regex reg = new Regex(@"^[{(]?[0-9a-fA-F]{8}-([0-9a-fA-F]{4}-){3}[0-9a-fA-F]{12}[)}]?$");
            return reg.IsMatch(s);
        }

        public static bool IsURL(this string s)
        {
            Regex reg = new Regex(@"^\b(?:http(?:s)?:\/\/)?(?:www\.)?(?:[a-zA-Z0-9][a-zA-Z0-9\-]*[a-zA-Z0-9]\.)+(?:[a-zA-Z0-9][a-zA-Z0-9\-]*[a-zA-Z0-9])(?::\d+)?(?:\/\w+(?:\.\w+)?)*((\/)?\?\w+=\w+(?:&\w+=\w+)*)?(\/)?(#\w+)?$");
            return reg.IsMatch(s);
        }

        public static bool IsDate(this string s)
        {
            Regex reg = new Regex(@"^([012][1-9]|10|20|30|31)/(01|03|05|07|08|10|12)/((1[6-9]|[2-9][0-9])[0-9]{2})|([012][1-9]|10|20|30)/(04|06|09|11)/((1[6-9]|[2-9][0-9])[0-9]{2})|29/02/((1[6-9]|[2-9][0-9])(04|08|[13579][26]|[2468][480])|(16|[2468][048]|[3579][26])00)|(0[1-9]|1[0-9]|2[0-8])/02/((1[6-9]|[2-9][0-9])[0-9]{2})$");
            return reg.IsMatch(s);
        }
        public static bool IsPrice(this string s)
        {
            Regex reg = new Regex(@"^\d{1,}(\.\d{0,2})? ?р(уб)?\.?$");
            return reg.IsMatch(s);
        }

        public static bool IsValidPass(this string s)
        {
            Regex reg = new Regex(@"((?=.*\d)(?=.*[A-Z])(?=.*[a-z])(?!.* ).{8,})");
            return reg.IsMatch(s);
        }
    }
}
