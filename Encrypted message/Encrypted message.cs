using System;

    class Encrypted 
    {
        static void Main()
        {
            string[] inputArr = Console.ReadLine().Split('~');
            int keyLenght = Convert.ToInt32(Convert.ToString(inputArr[1][0]));
            int alphabetLenght = Convert.ToInt32( Convert.ToString(inputArr[1][1]) + Convert.ToString(inputArr[1][2]));

            string key = "";
            string alphabet = "";
            string encryptedString = inputArr[2].Substring(alphabetLenght, inputArr[2].Length - alphabetLenght)
                                     + inputArr[0].Substring(0, inputArr[0].Length - keyLenght);

            for (int i = inputArr[0].Length - keyLenght; i < inputArr[0].Length; i++)
            {
                key += inputArr[0][i];
            }
            for (int i = 0; i < alphabetLenght; i++)
            {
                alphabet += inputArr[2][i];
            }

            string original = "";

            int indexString = 0;
            while (indexString < encryptedString.Length)
	        {
                
	         for (int j = 0; j < keyLenght; j++)
                {
                        if (indexString == encryptedString.Length-1)
                    {
                       keyLenght=1;
                    }
                                  
                        int indexOfString = alphabet.IndexOf(encryptedString[indexString]);
                        int indexOfKey = alphabet.IndexOf(key[j]);
                        int indexOfOriginalChar = indexOfString - indexOfKey;
                        if ( (indexOfOriginalChar) < 0)
	                    {
		                        indexOfOriginalChar += alphabetLenght;
	                    }

                        original+= alphabet[indexOfOriginalChar];
                   
                        indexString++;
                
                }
	        }

            //Console.WriteLine(alphabet);
            //Console.WriteLine(keyLenght);
            //Console.WriteLine(alphabetLenght);
            //Console.WriteLine(key);
            //Console.WriteLine(encryptedString);
            Console.WriteLine(original);


        }
    }
