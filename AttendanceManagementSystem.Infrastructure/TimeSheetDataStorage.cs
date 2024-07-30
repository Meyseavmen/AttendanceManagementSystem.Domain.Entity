//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//using System.Text.Json;
//using AttendanceManagementSystem.Application;
//namespace AttendanceManagementSystem.Infrastructure;

//public class TimeSheetDataStorage
//{
//    public static void SaveTimeSheetToStorage(FileTimeSheet AttenList)
//    {
//        var jsonString = JsonSerializer.Serialize<FileTimeSheet>(AttenList);
//        File.WriteAllText("timesheet.json",jsonString);
//    }
//    public static FileTimeSheet LoadTimeSheetFromStorage()
//    {
//        using FileStream stream = File.Open("timesheet.json", FileMode.OpenOrCreate);
//        if (stream.Length > 0)
//        {
//            var loadList = JsonSerializer.Deserialize <FileTimeSheet>(stream);
//            return loadList!;
//        }
//        return new FileTimeSheet();
//    }
//}
