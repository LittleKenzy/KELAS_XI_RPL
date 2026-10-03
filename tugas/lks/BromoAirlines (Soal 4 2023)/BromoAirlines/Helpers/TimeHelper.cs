using System;
using System.Text.RegularExpressions;

namespace BromoAirlines.Helpers
{ 
    public static class TimeHelper
    {
        //Mengubah string "01 jam 30 menit" menjadi integer (90)
        public static int ConvertToMinutes(string durasiText)
        {
            if (string.IsNullOrWhiteSpace(durasiText)) return 0;

            var match = Regex.Match(durasiText.Trim(), @"^(\d+)\s*jam\s*(\d+)\s*menit$", RegexOptions.IgnoreCase);
            if(match.Success)
            {
                int jam = int.Parse(match.Groups[1].Value);
                int menit = int.Parse(match.Groups[2].Value);
                return (jam * 60) + menit;
            }
            return 0;
        }

        //mengubah integer menit (90) menjadi string "01 jam 30 menit"
        public static string ConvertToFormattedString(int totalMenit)
        {
            int jam = totalMenit / 60;
            int menit = totalMenit % 60;
            return $"{jam:D2} jam {menit:D2} menit";
        }
    }
}