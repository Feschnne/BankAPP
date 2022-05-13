open System

Console.WriteLine " ==============================="
Console.WriteLine " ==      BANK APPLICATION     =="
Console.WriteLine " ==       by Felipe S.N       =="
Console.WriteLine " ==============================="
Console.WriteLine ""

Console.WriteLine " You have 6 different accounts (0001..0006) ."
Console.WriteLine " "


Console.WriteLine " ------- NAVIGATION MENU --------"
Console.WriteLine " --                            --"
Console.WriteLine " -  1. Check all balances       -"   
Console.WriteLine " -  2. Check specific balance   -"
Console.WriteLine " -  3. Deposit                  -"
Console.WriteLine " -  4. Withdraw                 -"
Console.WriteLine " --                            --"
Console.WriteLine " --------------------------------"
Console.WriteLine ""
Console.Write " Please select your option > "
let menuOption = int(Console.ReadLine())
Console.WriteLine " "

//TASK 2 
type Account = {accountNumber:string; balance:float}
               
               member this.Print =
                    Console.WriteLine " "
                    Console.Write " Account Number > "
                    Console.Write (this.accountNumber)
                    Console.Write "   "
                    Console.Write " Balance > "
                    Console.WriteLine(this.balance:float)
                    Console.WriteLine ""
                

let account1: Account = {accountNumber = "0001"; balance = 0.02}
let account2: Account = {accountNumber = "0002"; balance = 15.12}
let account3: Account = {accountNumber = "0003"; balance = 51.47}
let account4: Account = {accountNumber = "0004"; balance = 239.33}
let account5: Account = {accountNumber = "0005"; balance = 167.21}
let account6: Account = {accountNumber = "0006"; balance = 5.68}

let accounts1 (accountNumber: string, balance:float) = [(account1.accountNumber, account1.balance); (account2.accountNumber, account2.balance);
                                                        (account3.accountNumber, account3.balance); (account4.accountNumber, account4.balance);
                                                        (account5.accountNumber, account5.balance); (account6.accountNumber, account6.balance)]

let accounts2:float list = [account1.balance;account2.balance;
                           account3.balance;account4.balance;
                           account5.balance;account6.balance]


//TASK 2 

let CheckBalance account =
    match account with 
    | _ when account.balance < 10.0 -> Console.WriteLine "Your balance is LOW"
    | _ when account.balance >= 10.0 && account.balance <= 100.0 -> Console.WriteLine "Your balance is OK"
    | _ when account.balance > 100.0 -> Console.WriteLine "Your balance is HIGH"

if menuOption = 1   then    Console.WriteLine ""
                            Console.Write " Account number > 0001   Balance > "
                            Console.Write account1.balance
                            Console.Write "      "
                            Console.WriteLine (CheckBalance(account1))
                            Console.Write " Account number > 0002   Balance > "
                            Console.Write account2.balance
                            Console.Write "     "
                            Console.WriteLine (CheckBalance(account2))
                            Console.Write " Account number > 0003   Balance > "
                            Console.Write account3.balance
                            Console.Write "     "
                            Console.WriteLine (CheckBalance(account3))
                            Console.Write " Account number > 0004   Balance > "
                            Console.Write account4.balance
                            Console.Write "    "
                            Console.WriteLine (CheckBalance(account4))
                            Console.Write " Account number > 0005   Balance > "
                            Console.Write account5.balance
                            Console.Write "    "
                            Console.WriteLine (CheckBalance(account5))
                            Console.Write " Account number > 0006   Balance > "
                            Console.Write account6.balance
                            Console.Write "      "
                            Console.WriteLine (CheckBalance(account6))





if menuOption = 2 then      Console.WriteLine " "
                            Console.Write " Please enter the number of the account (0001..0006) > "
                            let accountChosen = string(Console.ReadLine())

                            if accountChosen = "0001" then account1.Print
                            if accountChosen = "0002" then account2.Print
                            if accountChosen = "0003" then account3.Print
                            if accountChosen = "0004" then account4.Print
                            if accountChosen = "0005" then account5.Print
                            if accountChosen = "0006" then account6.Print



if menuOption = 3 then      Console.Write " Account to make the deposit to (0001..0006) > "
                            let accountForDeposit = string(Console.ReadLine())

                            Console.Write " Amount to deposit > "
                            let mutable amountDeposit = double(Console.ReadLine())
                            Console.WriteLine ""
                         
                            if accountForDeposit = "0001" then 
                                Console.WriteLine " DEPOSIT SUCCESSFULL!"
                                Console.WriteLine ""
                                Console.Write " Balance before deposit was > "
                                Console.WriteLine account1.balance
                                let calc1 = amountDeposit + account1.balance
                                Console.Write " Your current balance is > "
                                Console.WriteLine calc1

                            if accountForDeposit = "0002" then 
                                Console.WriteLine " DEPOSIT SUCCESSFULL!"
                                Console.WriteLine ""
                                Console.Write " Balance before deposit was > "
                                Console.WriteLine account2.balance
                                let calc2 = amountDeposit + account2.balance
                                Console.Write " Your current balance is > "
                                Console.WriteLine calc2

                            if accountForDeposit = "0003" then 
                                Console.WriteLine " DEPOSIT SUCCESSFULL!"
                                Console.WriteLine ""
                                Console.Write " Balance before deposit was > "
                                Console.WriteLine account3.balance
                                let calc3 = amountDeposit + account3.balance
                                Console.Write " Your current balance is > "
                                Console.WriteLine calc3

                            if accountForDeposit = "0004" then 
                                Console.WriteLine " DEPOSIT SUCCESSFULL!"
                                Console.WriteLine ""
                                Console.Write " Balance before deposit was > "
                                Console.WriteLine account4.balance
                                let calc4 = amountDeposit + account4.balance
                                Console.Write " Your current balance is > "
                                Console.WriteLine calc4

                            if accountForDeposit = "0005" then 
                                Console.WriteLine " DEPOSIT SUCCESSFULL!"
                                Console.WriteLine ""
                                Console.Write " Balance before deposit was > "
                                Console.WriteLine account5.balance
                                let calc5 = amountDeposit + account5.balance
                                Console.Write " Your current balance is > "
                                Console.WriteLine calc5

                            if accountForDeposit = "0006" then 
                                Console.WriteLine " DEPOSIT SUCCESSFULL!"
                                Console.WriteLine ""
                                Console.Write " Balance before deposit was > "
                                Console.WriteLine account6.balance
                                let calc6 = amountDeposit + account6.balance
                                Console.Write " Your current balance is > "
                                Console.WriteLine calc6

if menuOption = 4 then      Console.Write " Account to make the withdraw from (0001..0006) > "
                            let accountForWithdraw = string(Console.ReadLine())
                            

                            Console.Write " Amount to withdraw > "
                            let mutable amountWithdraw = double(Console.ReadLine())
                            Console.WriteLine ""

                            if accountForWithdraw = "0001" then 
                                let calc21 = account1.balance - amountWithdraw
                                if amountWithdraw > account1.balance then Console.WriteLine " Transaction Cancelled. Insufficient balance."
                                if account1.balance > amountWithdraw then 
                                    Console.WriteLine " WITHDRAWAL SUCCESSFULL!"
                                    Console.WriteLine ""
                                    Console.Write " Balance before withdraw was > "
                                    Console.WriteLine account1.balance
                                    Console.Write " Your current balance is > "
                                    Console.WriteLine calc21
                            
                            if accountForWithdraw = "0002" then 
                                let calc22 = account2.balance - amountWithdraw
                                if amountWithdraw > account2.balance then Console.WriteLine " Transaction Cancelled. Insufficient balance."
                                if account2.balance > amountWithdraw then 
                                    Console.WriteLine " WITHDRAWAL SUCCESSFULL!"
                                    Console.WriteLine ""
                                    Console.Write " Balance before withdraw was > "
                                    Console.WriteLine account2.balance
                                    Console.Write " Your current balance is > "
                                    Console.WriteLine calc22

                            if accountForWithdraw = "0003" then 
                                let calc23 = account3.balance - amountWithdraw
                                if amountWithdraw > account3.balance then Console.WriteLine " Transaction Cancelled. Insufficient balance."
                                if account3.balance > amountWithdraw then 
                                    Console.WriteLine " WITHDRAWAL SUCCESSFULL!"
                                    Console.WriteLine ""
                                    Console.Write " Balance before withdraw was > "
                                    Console.WriteLine account3.balance
                                    Console.Write " Your current balance is > "
                                    Console.WriteLine calc23

                            if accountForWithdraw = "0004" then 
                                let calc24 = account4.balance - amountWithdraw
                                if amountWithdraw > account4.balance then Console.WriteLine " Transaction Cancelled. Insufficient balance."
                                if account4.balance > amountWithdraw then 
                                    Console.WriteLine " WITHDRAWAL SUCCESSFULL!"
                                    Console.WriteLine ""
                                    Console.Write " Balance before withdraw was > "
                                    Console.WriteLine account4.balance
                                    Console.Write " Your current balance is > "
                                    Console.WriteLine calc24

                            if accountForWithdraw = "0005" then 
                                let calc25 = account5.balance - amountWithdraw
                                if amountWithdraw > account5.balance then Console.WriteLine " Transaction Cancelled. Insufficient balance."
                                if account5.balance > amountWithdraw then 
                                    Console.WriteLine " WITHDRAWAL SUCCESSFULL!"
                                    Console.WriteLine ""
                                    Console.Write " Balance before withdraw was > "
                                    Console.WriteLine account5.balance
                                    Console.Write " Your current balance is > "
                                    Console.WriteLine calc25

                            if accountForWithdraw = "0006" then 
                                let calc26 = account6.balance - amountWithdraw
                                if amountWithdraw > account6.balance then Console.WriteLine " Transaction Cancelled. Insufficient balance."
                                if account6.balance > amountWithdraw then 
                                    Console.WriteLine " WITHDRAWAL SUCCESSFULL!"
                                    Console.WriteLine ""
                                    Console.Write " Balance before withdraw was > "
                                    Console.WriteLine account6.balance
                                    Console.Write " Your current balance is > "
                                    Console.WriteLine calc26






//TASK 3

Console.WriteLine ""
Console.WriteLine ""
Console.Write " List of account balances > "
Console.WriteLine accounts1 // There is an error when this value is displayed, as
                            // it does not display a list which contains strings and floats.


let accountDiff:float list = List.filter (fun n -> n >= 0.0 && n < 50.0 ) accounts2

Console.WriteLine ""
Console.Write " List of accounts with balances between 0.0 and 49.0 > "
Console.WriteLine accountDiff
Console.WriteLine ""

let matchAccWBa = List.exists (fun n -> n = 0.02) accountDiff
if matchAccWBa = true then Console.WriteLine " Balance > 0.02 pertains to Account > 0001"

let matchAccWBa2 = List.exists (fun n -> n = 15.12) accountDiff
if matchAccWBa = true then Console.WriteLine " Balance > 15.12 pertains to Account > 0002"

let matchAccWBa3 = List.exists (fun n -> n = 5.68) accountDiff
if matchAccWBa = true then Console.WriteLine " Balance > 5.68 pertains to Account > 0006"
Console.WriteLine ""



let accountDiff2:float list = List.filter (fun n -> n >= 50.0 ) accounts2


Console.Write " List of accounts with balances of more than 49.0 > "
Console.WriteLine accountDiff2
Console.WriteLine ""

let matchAccWBa4 = List.exists (fun n -> n = 51.47) accountDiff2
if matchAccWBa = true then Console.WriteLine " Balance > 51.47 pertains to Account > 0003"

let matchAccWBa5 = List.exists (fun n -> n = 239.33) accountDiff2
if matchAccWBa = true then Console.WriteLine " Balance > 239.33 pertains to Account > 0004"

let matchAccWBa6 = List.exists (fun n -> n = 167.21) accountDiff2
if matchAccWBa = true then Console.WriteLine " Balance > 167.21 pertains to Account > 0005"


//TASK 4
(*
Console.WriteLine ""
Console.WriteLine ""
Console.WriteLine " ======================="
Console.WriteLine " = SEAT BOOKING SYSTEM ="
Console.WriteLine " ======================="


Console.Write " Please type your name > "
let mutable customerName = string(Console.ReadLine())
Console.Write " Please choose a sit from 1..10 > "
let mutable customerSeat = int(Console.ReadLine())

type Ticket = {seat:int; customer:string}

                    member this.Print =
                        Console.WriteLine " "
                        Console.Write " Customer name > "
                        Console.Write (this.customer:string)
                        Console.Write "   "
                        Console.Write " Seat assigned > "
                        Console.WriteLine(this.seat:int)
                        Console.WriteLine ""


let customer1: Ticket = {seat = customerSeat; customer = customerName}
let customer2: Ticket = {seat = 2; customer = "Karla "}
let customer3: Ticket = {seat = 3; customer = "Ellie "}
let customer4: Ticket = {seat = 4; customer = "Darryl"}
let customer5: Ticket = {seat = 5; customer = "Ryan  "}
let customer6: Ticket = {seat = 6; customer = "Ernie "}
let customer7: Ticket = {seat = 7; customer = "Becky "}
let customer8: Ticket = {seat = 8; customer = "Laura "}
let customer9: Ticket = {seat = 9; customer = "Ana   "}
let customer10: Ticket = {seat = 10; customer = "Angie "}

customer1.Print
customer2.Print
customer3.Print
customer4.Print
customer5.Print
customer6.Print
customer7.Print
customer8.Print
customer9.Print
customer10.Print


let mutable tickets = [for n in 1..10 -> {Ticket.seat = n; Ticket.customer = "" }]

Console.WriteLine tickets
*)
