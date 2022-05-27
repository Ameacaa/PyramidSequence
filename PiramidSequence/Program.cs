class PiramidSequence
{
	static void pyramid()
	{
		char[] seqa = new char[2];
		char[] seql = { '1' };

		for (int e = 0; e < seql.Length; e++) { Console.Write(seql[e]); }
		Console.WriteLine();

		for (int r = 0; r < 5; r++)
        {
			int t = 1;
			if (seql.Length > 1)
			{
				char lval = seql[0], aval;
				int c = 1, p = 0;

				for (int i = 1; i < seql.Length; i++)
				{
					aval = seql[i];
					if (aval == lval)
					{
						c++;
						if (i == seql.Length - 1)
                        {
							seqa[p] = Convert.ToChar(c);
							seqa[p + 1] = lval;
						}
						continue;
					}
					else
					{
						seqa[p] = (char)c;
						seqa[p + 1] = lval;
						p += 2;
						c = 1;
						t++;
						lval = aval;
					}
				}

			}
			else
			{
				seqa[0] = '1';
				seqa[1] = seql[0];
				if (seqa[0] != seqa[1]) { t = 2; }
			}

			for (int e = 0; e < seqa.Length; e++) { Console.Write(seqa[e]); }
			Console.WriteLine();

			seql = seqa;
			seqa = new char[t * 2];
		}
		



	}


	static void Main()
	{
		pyramid();

	}
}


//char anb[100] = { '1', '.' }; // Actual piramid inumber, start with '1'
//char bnb[100]; // the following piramid number
//int n = 0, k = anb[0], pos = 0; // n for number of the same number, k for the actual number compare	

//for (int j = 0; j < 5; j++)
//{
//	pos = 0;
//	for (int i = 0; i < 100; i++)
//	{
//		if (anb[i] != '.')
//		{
//			printf("%c", anb[i]);
//			if (k == anb[i]) { n++; }
//			else
//			{
//				bnb[pos] = n;
//				bnb[pos + 1] = k;
//				k = anb[i];
//				n = 1;
//				pos += 2;
//			}
//		}
//		else
//		{
//			bnb[pos] = '.';
//			printf("\n");
//		}
//	}
//	int s = 0;
//	while (bnb[s] != '.')
//	{
//		anb[s] = bnb[s];
//		s++;
//	}
//}