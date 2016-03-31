number_of_participants  = int(input())
price_of_gift           = int(input())
total_budget            = 0

participant_budgets = []

for i in range(number_of_participants):
    participant_budget = int(input())
    participant_budgets.append(participant_budget)
    total_budget = total_budget + participant_budget

participant_budgets.sort()

participant_payments = []
if (total_budget < price_of_gift):
    print("IMPOSSIBLE")
else:
    number_of_participants_paied        = 0
    total_participants_paied            = 0
    goal_payment_from_each_participant  = 0
    
    for current_participant_budget in participant_budgets:
        goal_payment_from_each_participant = round((price_of_gift - total_participants_paied) / (number_of_participants - number_of_participants_paied))
        if (current_participant_budget < goal_payment_from_each_participant):
            participant_payments.append(current_participant_budget)
            total_participants_paied = total_participants_paied + current_participant_budget
        else:
            participant_payments.append(goal_payment_from_each_participant)
            total_participants_paied = total_participants_paied + goal_payment_from_each_participant
        number_of_participants_paied += 1
    
    participant_payments.sort()
    for payment in participant_payments:
        print(payment)