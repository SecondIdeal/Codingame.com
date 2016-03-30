using System;
using System.Collections.Generic;

class Solution
{
    static void Main()
    {
        int numberOfParticipants = int.Parse(Console.ReadLine());
        int priceOfGift = int.Parse(Console.ReadLine());
        int totalBudget = 0;

        List<int> participantBudgets = new List<int>();
        for (int i = 0; i < numberOfParticipants; i++)
        {
            int participantBudget = int.Parse(Console.ReadLine());
            totalBudget = totalBudget + participantBudget;

            participantBudgets.Add(participantBudget);
        }
        participantBudgets.Sort();

        List<int> participantPayments = new List<int>();
        if (totalBudget < priceOfGift)
            Console.WriteLine("IMPOSSIBLE");
        else
        {
            int numberOfParticipantsPaied = 0, totalParticipantsPaied = 0, goalPaymentFromEachParticipant = 0;
            foreach (int currentParticipantBudget in participantBudgets)
            {
                goalPaymentFromEachParticipant = (priceOfGift - totalParticipantsPaied) / (numberOfParticipants - numberOfParticipantsPaied);
                if (currentParticipantBudget < goalPaymentFromEachParticipant)
                {
                    participantPayments.Add(currentParticipantBudget);
                    totalParticipantsPaied = totalParticipantsPaied + currentParticipantBudget;
                }
                else
                {
                    participantPayments.Add(goalPaymentFromEachParticipant);
                    totalParticipantsPaied = totalParticipantsPaied + goalPaymentFromEachParticipant;
                }
                numberOfParticipantsPaied++;
            }
            participantPayments.Sort();
            foreach (int payment in participantPayments)
                Console.WriteLine(payment);
        }
    }
}