/*
 * Created by SharpDevelop.
 * User: HP8440P
 * Date: 20.01.2024
 * Time: 23:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace SmartStorage
{
	class Program2
	{
                void CardSearch () // Выдача карт от 0 до 9
                {
                for (int i = 0; i <= cardArray.Length+3; i++)
                { cardArray[i] = 0 ; }
                }
                void ChangeMove () // Смена хода
                {
                for (int i = 0; i <= cardArray.Length+3; i++)
                { cardArray[i] = lastCard ; }
                }
                void ChangeCards () // Запрет хода
                {
                for (int i = 0; i <= cardArray.Length+3; i++)
                { cardArray[i] = lastCard ; }
                }
                void ChangeColor () // Смена цвета
                {
                for (int i = 0; i <= cardArray.Length+3; i++)
                { cardArray[i] = lastCard ; }
                }
                void LeaveFromMove () // Пропуск хода
                {
                Arr [] cardArray = int [] ;
                for (int i = 0; i <= cardArray.Length+3; i++)
                { cardArray[i] = lastCard ; }
                }

		public static void Main(string[] args)
		{
			SCardSearch () ;
			ChangeMove () ;
			ChangeCards () ;
			ChangeColor () ;
			LeaveFromMove () ; // Поиск нужного метода
			Arr [] cardArray = int [] ;
			for (int i = 0; i <= cardArray.Length+3; i++)
			{ cardArray[i] = 0 ; }


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