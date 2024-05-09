//Victor Ivanov 11/6
// You specifically allowed me to use an array
using System;

public class Magic8Ball_VictorIvanov {
  public static void Main (string[] args){

    Random rnd = new Random();
    int a = rnd.Next(20);

    Console.WriteLine("What is your question? ");
    Console.ReadLine();
    Console.WriteLine(responses(a));

  }

  public static string responses (int num) {

    string[] answer = {
      "As I see it, yes",
    	"It is certain",
    	"It is decidedly so",
    	"Most likely",
    	"Outlook good",
    	"Signs point to yes",
    	"Without a doubt",
    	"Yes",
    	"Yes - definitely",
    	"You may rely on it",
    	"Reply hazy, try again",
    	"Ask again later",
    	"Better not tell you now",
    	"Cannot predict now",
    	"Concentrate and ask again",
    	"Don't count on it",
    	"My reply is no",
    	"My sources say no",
    	"Outlook not so good",
    	"Very doubtful" };

      switch(num) {
        case 0:
          return answer[0];
          break;
        case 1:
          return answer[1];
          break;
        case 2:
          return answer[2];
          break;
        case 3:
          return answer[3];
          break;
        case 4:
          return answer[4];
          break;
        case 5:
          return answer[5];
          break;
        case 6:
          return answer[6];
          break;
        case 7:
          return answer[7];
          break;
        case 8:
          return answer[8];
          break;
        case 9:
          return answer[9];
          break;
        case 10:
          return answer[10];
          break;
        case 11:
          return answer[11];
          break;
        case 12:
          return answer[12];
          break;
        case 13:
          return answer[13];
          break;
        case 14:
          return answer[14];
          break;
        case 15:
          return answer[15];
          break;
        case 16:
          return answer[16];
          break;
        case 17:
          return answer[17];
          break;
        case 18:
          return answer[18];
          break;
        case 19:
          return answer[19];
          break;
        default:
          return "something went wrong";


      }
  }
}
