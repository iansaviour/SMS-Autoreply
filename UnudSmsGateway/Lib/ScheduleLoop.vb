Module ScheduleLoop
    Sub process_loop()
        'repeat_interval or a set of repeat_year, repeat_month, repeat_day, repeat_week, and repeat_weekday data.

        Dim nowdate As Date = Now() ' change this date
        Dim _year, _month, _day, _week, _weekday As String
        Dim now_date_mysql As String = nowdate.ToString("yyyy-MM-dd HH:mm:ss")

        _year = nowdate.Year.ToString
        _month = nowdate.Month.ToString
        _day = nowdate.Day.ToString
        _week = GetWeekNumberOfMonth(nowdate)
        _weekday = Weekday(nowdate)

        Dim query As String = "SELECT EV.*"
        query += " FROM `events` EV"
        query += " RIGHT JOIN `events_meta` EM1 ON EM1.`event_id` = EV.`id`"
        query += " WHERE  (( UNIX_TIMESTAMP('" + now_date_mysql + "') - repeat_start) % repeat_interval = 0 )"
        query += " OR ( "
        query += " (repeat_year = '" + _year + "' OR repeat_year = '*' )"
        query += " AND"
        query += " (repeat_month = '" + _month + "' OR repeat_month = '*' )"
        query += " AND"
        query += " (repeat_day = '" + _day + "' OR repeat_day = '*' )"
        query += " AND"
        query += " (repeat_week = '" + _week + "' OR repeat_week = '*' )"
        query += " AND"
        query += " (repeat_weekday = '" + _weekday + "' OR repeat_weekday = '*' )"
        query += " AND repeat_start <= UNIX_TIMESTAMP('" + now_date_mysql + "'))"

        Console.WriteLine(convert_second("1.00:00:00").ToString)
    End Sub
    Function GetWeekNumberOfMonth(ByVal _date As DateTime) As Integer
        _date = _date.Date
        Dim firstMonthDay As New DateTime(_date.Year, _date.Month, 1)
        Dim firstMonthMonday As DateTime = firstMonthDay.AddDays((DayOfWeek.Monday + 7 - firstMonthDay.DayOfWeek) Mod 7)
        If firstMonthMonday > _date Then
            firstMonthDay = firstMonthDay.AddMonths(-1)
            firstMonthMonday = firstMonthDay.AddDays((DayOfWeek.Monday + 7 - firstMonthDay.DayOfWeek) Mod 7)
        End If
        Return (_date - firstMonthMonday).Days / 7 + 1
    End Function
    Function UnixTimeStampToDateTime(ByVal unixTimeStamp As Double) As DateTime
        ' Unix timestamp is seconds past epoch
        Dim dtDateTime As System.DateTime = New DateTime(1970, 1, 1, 0, 0, 0, _
         0, System.DateTimeKind.Utc)
        dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime()
        Return dtDateTime
    End Function

    Function convert_second(ByVal time_string As String) As Double
        'format string_time [hari].[jam]:[menit][detik]
        Dim ts As TimeSpan = TimeSpan.Parse(time_string)
        Dim totalSeconds As Double = ts.TotalSeconds
        Return totalSeconds
    End Function
    Function convert_from_second(ByVal sec As Integer) As TimeSpan
        Dim t As TimeSpan = TimeSpan.FromSeconds(sec)
        't.Days
        't.Hours
        't.Minutes
        't.Seconds
        Return t
    End Function
End Module
