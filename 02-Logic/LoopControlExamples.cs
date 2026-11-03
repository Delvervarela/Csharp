partial class Program
{
    static void LoopControlExamples()
    {
        
        for (int i = 0; i <10; i++)
        {
            if (i == 5)
            {
                break;
            }
            //WriteLine(i);


        }

        for (int i = 0; i <10; i++)
        {
            if (i == 5  || i == 7)
            {
                continue;
            }
            //WriteLine(i);


        }

         for (int i = 0; i <10; i++)
        {
            if (i == 3)
            {
               // return;
            }
            WriteLine(i);


        }


        //Bucles infinitos

       // while(true)
        //{
            //WriteLine("Esto se va a ejecutar para siempre");
        //}
        
        for(;;)
        {
            WriteLine("Esto se va a ejecutar");
            break;
        }

    }

}