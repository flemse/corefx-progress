namespace System.Globalization {
  public class ChineseLunisolarCalendar : EastAsianLunisolarCalendar {
    public ChineseLunisolarCalendar();
    public override int[] Eras { get; }
    public override DateTime MaxSupportedDateTime { get; }
    public override DateTime MinSupportedDateTime { get; }
    public override int GetEra(DateTime time);
  }
  public abstract class EastAsianLunisolarCalendar : Calendar {
    public override int TwoDigitYearMax { get; set; }
    public override DateTime AddMonths(DateTime time, int months);
    public override DateTime AddYears(DateTime time, int years);
    public int GetCelestialStem(int sexagenaryYear);
    public override int GetDayOfMonth(DateTime time);
    public override DayOfWeek GetDayOfWeek(DateTime time);
    public override int GetDayOfYear(DateTime time);
    public override int GetDaysInMonth(int year, int month, int era);
    public override int GetDaysInYear(int year, int era);
    public override int GetLeapMonth(int year, int era);
    public override int GetMonth(DateTime time);
    public override int GetMonthsInYear(int year, int era);
    public virtual int GetSexagenaryYear(DateTime time);
    public int GetTerrestrialBranch(int sexagenaryYear);
    public override int GetYear(DateTime time);
    public override bool IsLeapDay(int year, int month, int day, int era);
    public override bool IsLeapMonth(int year, int month, int era);
    public override bool IsLeapYear(int year, int era);
    public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era);
    public override int ToFourDigitYear(int year);
  }
  public class GregorianCalendar : Calendar {
    public GregorianCalendar();
    public GregorianCalendar(GregorianCalendarTypes type);
    public virtual GregorianCalendarTypes CalendarType { get; set; }
    public override int[] Eras { get; }
    public override DateTime MaxSupportedDateTime { get; }
    public override DateTime MinSupportedDateTime { get; }
    public override int TwoDigitYearMax { get; set; }
    public override DateTime AddMonths(DateTime time, int months);
    public override DateTime AddYears(DateTime time, int years);
    public override int GetDayOfMonth(DateTime time);
    public override DayOfWeek GetDayOfWeek(DateTime time);
    public override int GetDayOfYear(DateTime time);
    public override int GetDaysInMonth(int year, int month, int era);
    public override int GetDaysInYear(int year, int era);
    public override int GetEra(DateTime time);
    public override int GetLeapMonth(int year, int era);
    public override int GetMonth(DateTime time);
    public override int GetMonthsInYear(int year, int era);
    public override int GetYear(DateTime time);
    public override bool IsLeapDay(int year, int month, int day, int era);
    public override bool IsLeapMonth(int year, int month, int era);
    public override bool IsLeapYear(int year, int era);
    public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era);
    public override int ToFourDigitYear(int year);
  }
  public enum GregorianCalendarTypes {
    Arabic = 10,
    Localized = 1,
    MiddleEastFrench = 9,
    TransliteratedEnglish = 11,
    TransliteratedFrench = 12,
    USEnglish = 2,
  }
  public class HebrewCalendar : Calendar {
    public HebrewCalendar();
    public override int[] Eras { get; }
    public override DateTime MaxSupportedDateTime { get; }
    public override DateTime MinSupportedDateTime { get; }
    public override int TwoDigitYearMax { get; set; }
    public override DateTime AddMonths(DateTime time, int months);
    public override DateTime AddYears(DateTime time, int years);
    public override int GetDayOfMonth(DateTime time);
    public override DayOfWeek GetDayOfWeek(DateTime time);
    public override int GetDayOfYear(DateTime time);
    public override int GetDaysInMonth(int year, int month, int era);
    public override int GetDaysInYear(int year, int era);
    public override int GetEra(DateTime time);
    public override int GetLeapMonth(int year, int era);
    public override int GetMonth(DateTime time);
    public override int GetMonthsInYear(int year, int era);
    public override int GetYear(DateTime time);
    public override bool IsLeapDay(int year, int month, int day, int era);
    public override bool IsLeapMonth(int year, int month, int era);
    public override bool IsLeapYear(int year, int era);
    public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era);
    public override int ToFourDigitYear(int year);
  }
  public class HijriCalendar : Calendar {
    public HijriCalendar();
    public override int[] Eras { get; }
    public int HijriAdjustment { get; set; }
    public override DateTime MaxSupportedDateTime { get; }
    public override DateTime MinSupportedDateTime { get; }
    public override int TwoDigitYearMax { get; set; }
    public override DateTime AddMonths(DateTime time, int months);
    public override DateTime AddYears(DateTime time, int years);
    public override int GetDayOfMonth(DateTime time);
    public override DayOfWeek GetDayOfWeek(DateTime time);
    public override int GetDayOfYear(DateTime time);
    public override int GetDaysInMonth(int year, int month, int era);
    public override int GetDaysInYear(int year, int era);
    public override int GetEra(DateTime time);
    public override int GetLeapMonth(int year, int era);
    public override int GetMonth(DateTime time);
    public override int GetMonthsInYear(int year, int era);
    public override int GetYear(DateTime time);
    public override bool IsLeapDay(int year, int month, int day, int era);
    public override bool IsLeapMonth(int year, int month, int era);
    public override bool IsLeapYear(int year, int era);
    public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era);
    public override int ToFourDigitYear(int year);
  }
  public class JapaneseCalendar : Calendar {
    public JapaneseCalendar();
    public override int[] Eras { get; }
    public override DateTime MaxSupportedDateTime { get; }
    public override DateTime MinSupportedDateTime { get; }
    public override int TwoDigitYearMax { get; set; }
    public override DateTime AddMonths(DateTime time, int months);
    public override DateTime AddYears(DateTime time, int years);
    public override int GetDayOfMonth(DateTime time);
    public override DayOfWeek GetDayOfWeek(DateTime time);
    public override int GetDayOfYear(DateTime time);
    public override int GetDaysInMonth(int year, int month, int era);
    public override int GetDaysInYear(int year, int era);
    public override int GetEra(DateTime time);
    public override int GetLeapMonth(int year, int era);
    public override int GetMonth(DateTime time);
    public override int GetMonthsInYear(int year, int era);
    public override int GetWeekOfYear(DateTime time, CalendarWeekRule rule, DayOfWeek firstDayOfWeek);
    public override int GetYear(DateTime time);
    public override bool IsLeapDay(int year, int month, int day, int era);
    public override bool IsLeapMonth(int year, int month, int era);
    public override bool IsLeapYear(int year, int era);
    public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era);
    public override int ToFourDigitYear(int year);
  }
  public class JapaneseLunisolarCalendar : EastAsianLunisolarCalendar {
    public JapaneseLunisolarCalendar();
    public override int[] Eras { get; }
    public override DateTime MaxSupportedDateTime { get; }
    public override DateTime MinSupportedDateTime { get; }
    public override int GetEra(DateTime time);
  }
  public class JulianCalendar : Calendar {
    public JulianCalendar();
    public override int[] Eras { get; }
    public override DateTime MaxSupportedDateTime { get; }
    public override DateTime MinSupportedDateTime { get; }
    public override int TwoDigitYearMax { get; set; }
    public override DateTime AddMonths(DateTime time, int months);
    public override DateTime AddYears(DateTime time, int years);
    public override int GetDayOfMonth(DateTime time);
    public override DayOfWeek GetDayOfWeek(DateTime time);
    public override int GetDayOfYear(DateTime time);
    public override int GetDaysInMonth(int year, int month, int era);
    public override int GetDaysInYear(int year, int era);
    public override int GetEra(DateTime time);
    public override int GetLeapMonth(int year, int era);
    public override int GetMonth(DateTime time);
    public override int GetMonthsInYear(int year, int era);
    public override int GetYear(DateTime time);
    public override bool IsLeapDay(int year, int month, int day, int era);
    public override bool IsLeapMonth(int year, int month, int era);
    public override bool IsLeapYear(int year, int era);
    public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era);
    public override int ToFourDigitYear(int year);
  }
  public class KoreanCalendar : Calendar {
    public KoreanCalendar();
    public override int[] Eras { get; }
    public override DateTime MaxSupportedDateTime { get; }
    public override DateTime MinSupportedDateTime { get; }
    public override int TwoDigitYearMax { get; set; }
    public override DateTime AddMonths(DateTime time, int months);
    public override DateTime AddYears(DateTime time, int years);
    public override int GetDayOfMonth(DateTime time);
    public override DayOfWeek GetDayOfWeek(DateTime time);
    public override int GetDayOfYear(DateTime time);
    public override int GetDaysInMonth(int year, int month, int era);
    public override int GetDaysInYear(int year, int era);
    public override int GetEra(DateTime time);
    public override int GetLeapMonth(int year, int era);
    public override int GetMonth(DateTime time);
    public override int GetMonthsInYear(int year, int era);
    public override int GetWeekOfYear(DateTime time, CalendarWeekRule rule, DayOfWeek firstDayOfWeek);
    public override int GetYear(DateTime time);
    public override bool IsLeapDay(int year, int month, int day, int era);
    public override bool IsLeapMonth(int year, int month, int era);
    public override bool IsLeapYear(int year, int era);
    public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era);
    public override int ToFourDigitYear(int year);
  }
  public class KoreanLunisolarCalendar : EastAsianLunisolarCalendar {
    public KoreanLunisolarCalendar();
    public override int[] Eras { get; }
    public override DateTime MaxSupportedDateTime { get; }
    public override DateTime MinSupportedDateTime { get; }
    public override int GetEra(DateTime time);
  }
  public class PersianCalendar : Calendar {
    public PersianCalendar();
    public override int[] Eras { get; }
    public override DateTime MaxSupportedDateTime { get; }
    public override DateTime MinSupportedDateTime { get; }
    public override int TwoDigitYearMax { get; set; }
    public override DateTime AddMonths(DateTime time, int months);
    public override DateTime AddYears(DateTime time, int years);
    public override int GetDayOfMonth(DateTime time);
    public override DayOfWeek GetDayOfWeek(DateTime time);
    public override int GetDayOfYear(DateTime time);
    public override int GetDaysInMonth(int year, int month, int era);
    public override int GetDaysInYear(int year, int era);
    public override int GetEra(DateTime time);
    public override int GetLeapMonth(int year, int era);
    public override int GetMonth(DateTime time);
    public override int GetMonthsInYear(int year, int era);
    public override int GetYear(DateTime time);
    public override bool IsLeapDay(int year, int month, int day, int era);
    public override bool IsLeapMonth(int year, int month, int era);
    public override bool IsLeapYear(int year, int era);
    public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era);
    public override int ToFourDigitYear(int year);
  }
  public class TaiwanCalendar : Calendar {
    public TaiwanCalendar();
    public override int[] Eras { get; }
    public override DateTime MaxSupportedDateTime { get; }
    public override DateTime MinSupportedDateTime { get; }
    public override int TwoDigitYearMax { get; set; }
    public override DateTime AddMonths(DateTime time, int months);
    public override DateTime AddYears(DateTime time, int years);
    public override int GetDayOfMonth(DateTime time);
    public override DayOfWeek GetDayOfWeek(DateTime time);
    public override int GetDayOfYear(DateTime time);
    public override int GetDaysInMonth(int year, int month, int era);
    public override int GetDaysInYear(int year, int era);
    public override int GetEra(DateTime time);
    public override int GetLeapMonth(int year, int era);
    public override int GetMonth(DateTime time);
    public override int GetMonthsInYear(int year, int era);
    public override int GetWeekOfYear(DateTime time, CalendarWeekRule rule, DayOfWeek firstDayOfWeek);
    public override int GetYear(DateTime time);
    public override bool IsLeapDay(int year, int month, int day, int era);
    public override bool IsLeapMonth(int year, int month, int era);
    public override bool IsLeapYear(int year, int era);
    public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era);
    public override int ToFourDigitYear(int year);
  }
  public class TaiwanLunisolarCalendar : EastAsianLunisolarCalendar {
    public TaiwanLunisolarCalendar();
    public override int[] Eras { get; }
    public override DateTime MaxSupportedDateTime { get; }
    public override DateTime MinSupportedDateTime { get; }
    public override int GetEra(DateTime time);
  }
  public class ThaiBuddhistCalendar : Calendar {
    public ThaiBuddhistCalendar();
    public override int[] Eras { get; }
    public override DateTime MaxSupportedDateTime { get; }
    public override DateTime MinSupportedDateTime { get; }
    public override int TwoDigitYearMax { get; set; }
    public override DateTime AddMonths(DateTime time, int months);
    public override DateTime AddYears(DateTime time, int years);
    public override int GetDayOfMonth(DateTime time);
    public override DayOfWeek GetDayOfWeek(DateTime time);
    public override int GetDayOfYear(DateTime time);
    public override int GetDaysInMonth(int year, int month, int era);
    public override int GetDaysInYear(int year, int era);
    public override int GetEra(DateTime time);
    public override int GetLeapMonth(int year, int era);
    public override int GetMonth(DateTime time);
    public override int GetMonthsInYear(int year, int era);
    public override int GetWeekOfYear(DateTime time, CalendarWeekRule rule, DayOfWeek firstDayOfWeek);
    public override int GetYear(DateTime time);
    public override bool IsLeapDay(int year, int month, int day, int era);
    public override bool IsLeapMonth(int year, int month, int era);
    public override bool IsLeapYear(int year, int era);
    public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era);
    public override int ToFourDigitYear(int year);
  }
  public class UmAlQuraCalendar : Calendar {
    public UmAlQuraCalendar();
    public override int[] Eras { get; }
    public override DateTime MaxSupportedDateTime { get; }
    public override DateTime MinSupportedDateTime { get; }
    public override int TwoDigitYearMax { get; set; }
    public override DateTime AddMonths(DateTime time, int months);
    public override DateTime AddYears(DateTime time, int years);
    public override int GetDayOfMonth(DateTime time);
    public override DayOfWeek GetDayOfWeek(DateTime time);
    public override int GetDayOfYear(DateTime time);
    public override int GetDaysInMonth(int year, int month, int era);
    public override int GetDaysInYear(int year, int era);
    public override int GetEra(DateTime time);
    public override int GetLeapMonth(int year, int era);
    public override int GetMonth(DateTime time);
    public override int GetMonthsInYear(int year, int era);
    public override int GetYear(DateTime time);
    public override bool IsLeapDay(int year, int month, int day, int era);
    public override bool IsLeapMonth(int year, int month, int era);
    public override bool IsLeapYear(int year, int era);
    public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era);
    public override int ToFourDigitYear(int year);
  }
}
