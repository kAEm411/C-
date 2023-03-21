namespace MTComm
{
    internal static class NSB60
    {
        static long  ibase = 60;

        static string[] Tab60 = {
            "0","1","2","3","4","5","6","7","8","9",
            "a","b","c","d","e","f","g","h","i","j",
            "k","l","m","n","o","p","r","s","t","u",
            "v","w","x","y","z","A","B","C","D","E",
            "F","G","H","I","J","K","L","M","N","O",
            "P","R","S","T","U","V","W","X","Y","Z"
        };

        public static string Convert(long Value)
        {
            string result = "";


            while (Value > 0)
            {
                result+=Tab60[Value%ibase];
                Value=Value/ibase;
            }

            return StringInvert(result);

        }

        public static string StringInvert(string str)
        {
            string lStr = "";

            while (str.Length>0)
            {
                lStr += str[str.Length-1];
                str=str.Remove(str.Length-1);
            }
            return lStr;
        }
    }


}
