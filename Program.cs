/*
 * Created by SharpDevelop.
 * User: HP8440P
 * Date: 20.01.2024
 * Time: 17:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace SmartStorage
{
	class Program
	{
		public static void Main(string[] args)
		{
			Switch cardGame:
                         Case 1: // Выдача карт от 0 до 9
                         Arr [] cardArray = int [] ;
                         for (int i = 0; i <= cardArray.Length; i++)
                         { cardArray[i] = 0; }
                         Break;
                         Case 2: // противоположенному игроку +4 карты
                         Arr [] cardArray = int [] ;
                         for (int i = 0; i <= cardArray.Length; i++)
                         { cardArray[i] = 10; }
                         Break;
                         Case 3: // противоположенному игроку +2 карты
                         Arr [] cardArray = int [] ;
                         for (int i = 0; i <= cardArray.Length; i++)
                         { cardArray[i] = 11; }
                         Break;
                         Case 4: // смена цвета
                         Arr [] cardArray = int [] ;
                         for (int i = 0; i <= cardArray.Length; i++)
                         { cardArray[i] = 12; }
                         Break;
                         Case 5: // смена хода
                         Arr [] cardArray = int [] ;
                         for (int i = 0; i <= cardArray.Length; i++)
                         { cardArray[i] = 13; }
                         Break;
                         Case 6: // запрет хода
                         Arr [] cardArray = int [] ;
                         for (int i = 0; i <= cardArray.Length; i++)
                         { cardArray[i] = 14; }
                         Break;
                         Case 7: // Взять дополнительно +4 карты
                         Arr [] cardArray = int [] ;
                         for (int i = 0; i <= cardArray.Length+3; i++)
                         { cardArray[i] = 0; }
                         lastMove = 0 ;
                         Break;
                         Case 8: // действие игрока
                         lastMove = 1 ;
                         Break;

				}	
			}
			
			
			}
			/*
			  * 
			  * 
			  * 
			  * Данный код педоставлен в ознакомительных целях, для конкетного внедрения на определенной системе удет нужна доработка под потребноси этой системы.
			  * This code is provided in acquittal purposes, for a particular implementation on a certain system, refinement will be needed for the need of this system.
			  * 
			  * 
			  * 
			  * */
		}
	}
}