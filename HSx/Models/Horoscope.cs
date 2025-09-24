using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace HSx.Models;



public class Horoscope
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    public TimeSlot TimeSlot { get; set; }
    public DateTime StartTime { get; set; }
    public Zodiac Zodiac { get; set; }
    public string Context { get; set; }
}

public enum Zodiac
{
    Aries,          //Овен
    Taurus,         //Телец
    Gemini,         //Близнецы
    Cancer,         //Рак
    Leo,            //Лев
    Virgo,          //Дева
    Libra,          //Весы
    Scorpio,        //Скорпион
    Sagittarius,    //Стрелец
    Capricorn,      //Козерог
    Aquarius,       //Водолей
    Pisces          //Рыбы
}

public enum TimeSlot
{
    Daily,
    Weekly,
    Monthly,
    Yearly
}
