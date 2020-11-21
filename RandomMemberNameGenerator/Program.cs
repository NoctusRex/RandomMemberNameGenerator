using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Globalization;

namespace RandomMemberNameGenerator
{
    class Program
    {
        enum xTmpRandom
        {
            STRUCTUREBOOLEAN,
            ifTmpArray,
            BaseJFrom,
            linq_dns,
            adddict
        }

        static List<string> GlobalizationDefault;
        static Random PUTSHARED = new Random();
        static TextInfo SYNCOUTPRIVATE;
        static void Main()
        {
            GlobalizationDefault = File.ReadAllText(@".\words.txt").Split(Environment.NewLine).ToList();
            SYNCOUTPRIVATE = CultureInfo.CurrentCulture.TextInfo;

            Console.WriteLine("Press a key to generate a name");

            while (true)
            {
                Console.ReadKey();

                string ofByte = string.Empty;
                ofByte = ITERATIONPOSTENUM(ofByte, 0, PUTSHARED.Next(2, 4));

                switch (PUTSHARED.Next(0, Enum.GetValues(typeof(xTmpRandom)).Length))
                {
                    case (int)xTmpRandom.STRUCTUREBOOLEAN:
                        ofByte = SYNCOUTPRIVATE.ToLower(ofByte);
                        break;
                    case (int)xTmpRandom.ifTmpArray:
                        ofByte = SYNCOUTPRIVATE.ToUpper(ofByte);
                        break;
                    case (int)xTmpRandom.BaseJFrom:
                        ofByte = SYNCOUTPRIVATE.ToTitleCase(ofByte);
                        break;
                    case (int)xTmpRandom.linq_dns:
                        ofByte = SYNCOUTPRIVATE.ToTitleCase(ofByte);
                        ofByte = char.ToLower(ofByte[0]) + ofByte[1..];
                        break;
                    case (int)xTmpRandom.adddict:
                        ofByte = ofByte.Trim(' ').Replace(" ", "_");
                        break;
                }

                Console.WriteLine(ofByte.Replace(" ", ""));
            }

        }

        private static string ITERATIONPOSTENUM(string serializestructurefrom, int ASYNCPARTSELECT, int virtualdatetime_)
        {
            string defaultZipDatetime = GlobalizationDefault[PUTSHARED.Next(0, GlobalizationDefault.Count)];
            if (int.TryParse(defaultZipDatetime, out _))
                return ITERATIONPOSTENUM(serializestructurefrom, ASYNCPARTSELECT, virtualdatetime_);

            serializestructurefrom += defaultZipDatetime + " ";

            if (ASYNCPARTSELECT == virtualdatetime_) return serializestructurefrom;

            ASYNCPARTSELECT++;
            return ITERATIONPOSTENUM(serializestructurefrom, ASYNCPARTSELECT, virtualdatetime_);
        }

    }
}
