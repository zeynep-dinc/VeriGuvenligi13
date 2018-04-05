using System;
using System.Text;

namespace VeriGuvenligi13
{
    class Sifreleme
    {
        public string sifreleme(string gelen)
        {
          //  string key = null;
            StringBuilder builder = new StringBuilder();
            int i = 0;
            char[] vs = new char[gelen.Length];
            foreach (char a in gelen)
            {
                vs[i] = a;
                i++;//şifreyi karakter karakter ayırıyorum
            }
            string[] yenihali = new string[i];
            for (int j = 0; j < i; j++)
            {//her karaktere karşılık gelen saat vedakika karşılığında bir değer veriliyor büyük küçük harf,rakam ve özel karakter ayrımı olacağı için her biri switch case ile yaptım 

                switch (vs[j])
                {
                    case 'A': yenihali[j] = "2349"; break;
                    case 'B': yenihali[j] = "2348"; break;
                    case 'C': yenihali[j] = "2347"; break;
                    case 'Ç': yenihali[j] = "2346"; break;
                    case 'D': yenihali[j] = "2355"; break;
                    case 'E': yenihali[j] = "2354"; break;
                    case 'F': yenihali[j] = "2353"; break;
                    case 'G': yenihali[j] = "2352"; break;
                    case 'Ğ': yenihali[j] = "2351"; break;
                    case 'H': yenihali[j] = "2350"; break;
                    case 'I': yenihali[j] = "2329"; break;
                    case 'İ': yenihali[j] = "2328"; break;
                    case 'J': yenihali[j] = "2327"; break;
                    case 'K': yenihali[j] = "2326"; break;
                    case 'L': yenihali[j] = "2325"; break;
                    case 'M': yenihali[j] = "2324"; break;
                    case 'N': yenihali[j] = "2323"; break;
                    case 'O': yenihali[j] = "2322"; break;
                    case 'Ö': yenihali[j] = "2321"; break;
                    case 'P': yenihali[j] = "2340"; break;
                    case 'R': yenihali[j] = "2339"; break;
                    case 'S': yenihali[j] = "2338"; break;
                    case 'Ş': yenihali[j] = "2337"; break;
                    case 'T': yenihali[j] = "2336"; break;
                    case 'U': yenihali[j] = "2345"; break;
                    case 'Ü': yenihali[j] = "2344"; break;
                    case 'V': yenihali[j] = "2343"; break;
                    case 'W': yenihali[j] = "2342"; break;
                    case 'X': yenihali[j] = "2341"; break;
                    case 'Q': yenihali[j] = "2330"; break;
                    case 'Y': yenihali[j] = "2319"; break;
                    case 'Z': yenihali[j] = "2318"; break;
                    //değerler rastgele seçilmiştir
                    //Küçük harf sıkalası
                    case 'a': yenihali[j] = "1919"; break;
                    case 'b': yenihali[j] = "1918"; break;
                    case 'c': yenihali[j] = "1957"; break;
                    case 'ç': yenihali[j] = "1956"; break;
                    case 'd': yenihali[j] = "1955"; break;
                    case 'e': yenihali[j] = "1954"; break;
                    case 'f': yenihali[j] = "1953"; break;
                    case 'g': yenihali[j] = "1952"; break;
                    case 'ğ': yenihali[j] = "1951"; break;
                    case 'h': yenihali[j] = "1950"; break;
                    case 'ı': yenihali[j] = "1949"; break;
                    case 'i': yenihali[j] = "1948"; break;
                    case 'j': yenihali[j] = "1927"; break;
                    case 'k': yenihali[j] = "1926"; break;
                    case 'l': yenihali[j] = "1925"; break;
                    case 'm': yenihali[j] = "1924"; break;
                    case 'n': yenihali[j] = "1923"; break;
                    case 'o': yenihali[j] = "1922"; break;
                    case 'ö': yenihali[j] = "1921"; break;
                    case 'p': yenihali[j] = "1920"; break;
                    case 'r': yenihali[j] = "1919"; break;
                    case 's': yenihali[j] = "1938"; break;
                    case 'ş': yenihali[j] = "1937"; break;
                    case 't': yenihali[j] = "1936"; break;
                    case 'u': yenihali[j] = "1935"; break;
                    case 'ü': yenihali[j] = "1934"; break;
                    case 'v': yenihali[j] = "1933"; break;
                    case 'w': yenihali[j] = "1932"; break;
                    case 'x': yenihali[j] = "1931"; break;
                    case 'q': yenihali[j] = "1930"; break;
                    case 'y': yenihali[j] = "1929"; break;
                    case 'z': yenihali[j] = "1928"; break;
                    //özel işaret tablosu
                    case '(': yenihali[j] = "0600"; break;
                    case ')': yenihali[j] = "0601"; break;
                    case '!': yenihali[j] = "0602"; break;
                    case '^': yenihali[j] = "0603"; break;
                    case '*': yenihali[j] = "0604"; break;
                    case '/': yenihali[j] = "0655"; break;
                    case '+': yenihali[j] = "0656"; break;
                    case '-': yenihali[j] = "0657"; break;
                    case '?': yenihali[j] = "0658"; break;
                    case '_': yenihali[j] = "0659"; break;
                    case '=': yenihali[j] = "0610"; break;
                    case '}': yenihali[j] = "0611"; break;
                    case ']': yenihali[j] = "0612"; break;
                    case '[': yenihali[j] = "0613"; break;
                    case '{': yenihali[j] = "0614"; break;
                    case '&': yenihali[j] = "0615"; break;
                    case '%': yenihali[j] = "0616"; break;
                    case '$': yenihali[j] = "0617"; break;
                    case '#': yenihali[j] = "0618"; break;
                    case '"': yenihali[j] = "0619"; break;
                    case '@': yenihali[j] = "0620"; break;
                    case 'æ': yenihali[j] = "0631"; break;
                    case '€': yenihali[j] = "0632"; break;
                    case ':': yenihali[j] = "0633"; break;
                    case '<': yenihali[j] = "0634"; break;
                    case '>': yenihali[j] = "0625"; break;
                    case '|': yenihali[j] = "0626"; break;
                    case '~': yenihali[j] = "0627"; break;
                    case '´': yenihali[j] = "0628"; break;
                    case 'Æ': yenihali[j] = "0629"; break;
                    case '¨': yenihali[j] = "0630"; break;
                    case 'ß': yenihali[j] = "0651"; break;
                    case '₺': yenihali[j] = "0650"; break;
                    case '£': yenihali[j] = "0649"; break;
                    case ';': yenihali[j] = "0648"; break;
                    case 'é': yenihali[j] = "0647"; break;
                    case ' ': yenihali[j] = "0646"; break;
                    case '☻':yenihali[j] = "0219";break;
                    case '♥': yenihali[j] = "0220"; break;
                    case '♦': yenihali[j] = "0239"; break;
                    case '♣':yenihali[j] = "0237"; break;
                    case '♠':yenihali[j] = "0249"; break;
                    case '•':yenihali[j] = "0259"; break;
                    case '◘':yenihali[j] = "0209"; break;
                    case'◙':yenihali[j] = "0210"; break;
                    case '♂':yenihali[j] = "0211"; break;
                    case '☺':yenihali[j] = "0212"; break;
                    case'♪':yenihali[j] = "0213"; break;
                    case'♫':yenihali[j] = "0214"; break;
                    case'☼':yenihali[j] = "0215"; break;
                    case'►':yenihali[j] = "0216"; break;
                    case'◄':yenihali[j] = "0217"; break;
                    case '↕':yenihali[j] = "0218"; break;
                    case '‼':yenihali[j] = "0229"; break;
                    case '\'': yenihali[j] = "0228"; break;
                    case '§': yenihali[j] = "0227"; break;
                    case '▬': yenihali[j] = "0226"; break;
                    case '↨': yenihali[j] = "0225"; break;
                    case '↑': yenihali[j] = "0224"; break;
                    case '↓':yenihali[j] = "0223"; break;
                    case '→': yenihali[j] = "0222"; break;
                    case'←': yenihali[j] = "0221"; break;
                    case '∟':yenihali[j] = "0247"; break;
                    case '▼': yenihali[j] = "0248"; break;
                    //rakamlar 
                    //burada hiçbirinin bi ortaklık göstermemesi durumu tahmin edilebilirliği en yüksek olduğu için alakasız verdim
                    case '0': yenihali[j] = "1500"; break;
                    case '1': yenihali[j] = "1130"; break;
                    case '2': yenihali[j] = "1249"; break;
                    case '3': yenihali[j] = "1750"; break;
                    case '4': yenihali[j] = "1825"; break;
                    case '5': yenihali[j] = "1320"; break;
                    case '6': yenihali[j] = "0135"; break;
                    case '7': yenihali[j] = "1207"; break;
                    case '8': yenihali[j] = "0341"; break;
                    case '9': yenihali[j] = "0518"; break;
                }
            }
            for (int j = 0; j < i; j++)
            {
                //key = key + yenihali[j];
                builder.Append(yenihali[j]);
            }
            return builder.ToString();
        }
    }
}
