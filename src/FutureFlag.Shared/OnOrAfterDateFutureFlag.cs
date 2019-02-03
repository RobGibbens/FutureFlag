using System;
using FutureFlag.Base;

namespace FutureFlag
{
    public class OnOrAfterDateFutureFlag : DateFutureFlag
    {
        public string Date { get; set; }
        public override bool IsEnabled => (UseUtc? UtcNow : Now) >= DateTime.Parse(Date, CultureInfo.DateTimeFormat);
    }
}