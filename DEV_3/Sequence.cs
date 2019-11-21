using System;

namespace DEV_3
{
    class Sequence
    {
        private string str;
        public Sequence(string str)
        {
            if(str == "")
            {
                throw new Exception();
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (!((int)str[i] == 1025 || ((int)str[i] >= 1040 && (int)str[i] <= 1103) ||
                    (int)str[i] == 1105 || ((int)str[i] >= 65 && (int)str[i] <= 90) || ((int)str[i] >= 97 && (int)str[i] <= 122)))
                {
                    throw new Exception();
                }
            }
            this.str = str;
        }
        private bool StrIsCyrillic(int index)
        {
            return ((str[index] >= 1040 && str[index] <= 1103) || str[index] == 1025 || str[index] == 1105);
        }
        private string CharConverter(string c)
        {
            if ((int)c[0] == 1025 || ((int)c[0] >= 1040 && (int)c[0] <= 1103) || (int)c[0] == 1105)
            {
                string[] latinToCyrillicTab = ("A B V G D E ZH Z I Y K L M N O P R S T U F KH TS CH SH SCH ' Y ' E YU YA " +
                    "a b v g d e zh z i y k l m n o p r s t u f kh ts ch sh sch ' y ' e yu ya").Split();
                if (c[0] == 1025)
                    return "YO";
                else if (c[0] == 1105)
                    return "yo";
                else
                    return latinToCyrillicTab[c[0] - 1040];
            }
            else if (((int)c[0] >= 65 && (int)c[0] <= 90) || ((int)c[0] >= 97 && (int)c[0] <= 122))
            {
                string[] cyrillicToLatiinTab = ("ЭЙ БИ СИ ДИ И ЭФ ДЖИ ЭЙЧ АЙ ДЖЕЙ КЕЙ ЭЛ ЭМ ЭН ОУ ПИ КЬЮ АР ЭС ТИ Ю ВИ ДАБЛЮ ИКС УАЙ ЗЭД " +
                    "эй би си ди и эф джи эйч ай джей кей эл эм эн оу пи кью ар эс ти ю ви даблю икс уай зэд").Split();
                if ((int)c[0] >= 65 && (int)c[0] <= 90)
                    return cyrillicToLatiinTab[c[0] - 65];
                else
                    return cyrillicToLatiinTab[c[0] - 97];
            }
            else
                throw new Exception();
        }
        public string GetChangedString()
        {
            string result = null;
            bool IsCyrillic = StrIsCyrillic(0);
            for (int i = 0; i < str.Length; i++)
            {
                if (IsCyrillic != StrIsCyrillic(i))
                    throw new Exception();
                result += CharConverter(str[i].ToString());
            }
            return result;
        }
    }
}
