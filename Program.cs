
using TimeWithWork.Model;
using TimeWithWork.Service;

TimeService  timeService = new TimeService(20, 21, 2024);

timeService.GetInfo();

timeService.TimeDifference();
int res = timeService.FullHour();
System.Console.WriteLine(res);

