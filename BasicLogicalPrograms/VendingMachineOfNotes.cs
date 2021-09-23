using System;
using System.Collections.Generic;
using System.Text;

namespace BasicLogicalPrograms
{
    class VendingMachineOfNotes
    {
        public void Notes(int change)
        {
            int [] arr= { 1000, 500, 100, 50, 10, 5, 2, 1 };
            int[] notes = new int[8];
            int count = 0;
            Console.WriteLine("Amount needed from vending machine is= " + change);
            for(int i=0;i<arr.Length;i++)
            {
                while(change/arr[i]!=0)
                {
                    if(arr[i]==1000||arr[i]==100||arr[i]==10)
                    {
                        notes[i] = change / arr[i];
                        change %= arr[i];
                    }
                    else
                    {
                        notes[i] = ++count;
                        change %= arr[i];
                    }
                }
                count = 0;
            }
            for (int i = 0; i < notes.Length; i++)
            {
                count += notes[i];
                Console.WriteLine("Number of Rs. " + arr[i] + " Notes needed is =" + notes[i]);
            }
            Console.WriteLine("Total count of notes= " + count);
        }
    }
}
