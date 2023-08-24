using RedisApp;
using ServiceStack.Redis;

RedisHelper.SaveDate("localhost", "myName", "Albert Danilov");

string value = RedisHelper.ReadData("localhost", "myName");

Console.WriteLine(value);



