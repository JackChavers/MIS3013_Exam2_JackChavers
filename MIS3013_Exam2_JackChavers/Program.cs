// MIS 3013 005
// Exam 2
// October 25, 2023
// Jack Chavers, 113493948




Console.WriteLine("[EWZD] Jack Chavers, Exam 2");

int nOrders = 0;
int sublevel1Count = 0;
int sublevel2Count = 0;
int sublevel3Count = 0;


int CalSubtotalLevel(double subtotal)
{
    int sublevel;
    if (subtotal > 80.00)
    {
        sublevel = 3;
        sublevel3Count = sublevel3Count + 1;
        

    }
    else if (subtotal <= 80.00 && subtotal > 30)
    {
        sublevel = 2;
        sublevel2Count = sublevel2Count + 1;
        
    }
    else
    {
        sublevel = 1;
        sublevel1Count = sublevel1Count + 1;

    }
    return sublevel;


}


void PrintReceipt(double wApple,double wBanana,double subtotal,int subtotallevel)
{
    Console.WriteLine(@$"
RECEIPT
Apple weight: {wApple:F2}
Banana weight: {wBanana:F2}
Subtotal: {subtotal:C2}
Subtotal Level: {subtotallevel}
");

}




double CalSubtotal(double wapple,double wbanana)
{
    double subtotal = wapple * 2.49 + wbanana * 0.59;
    return subtotal;
}

string GetMenu()
{
    
    string menuStr=(@"
****************************
Sales System Menu
1. Add a new order
2. Show summary information
Press other keys to exit
****************************
");
    return menuStr;
}

double totalAppleW = 0;
double totalBananaW = 0;

double sumOfSubtotal = 0;




while (true)
{
    string getmenuStr = GetMenu();
    Console.WriteLine(getmenuStr);

    Console.Write("\nEnter option: ");
    string userChoiceStr;
    userChoiceStr = Console.ReadLine();

    if(userChoiceStr=="1")
    {

        nOrders = nOrders + 1;

        Console.Write("\nWeight of apples (lbs): ");
        string wAppleStr;
        wAppleStr=Console.ReadLine();
        double wAppleDbl;
        wAppleDbl = Convert.ToDouble(wAppleStr);
        totalAppleW = wAppleDbl + totalAppleW;

        Console.Write("Weight of bananas (lbs): ");
        string wBananaStr;
        wBananaStr = Console.ReadLine();
        double wBananaDbl;
        wBananaDbl = Convert.ToDouble(wBananaStr);
        totalBananaW = wBananaDbl + totalBananaW;

        double subtotal = CalSubtotal(wAppleDbl, wBananaDbl);
        sumOfSubtotal = subtotal + sumOfSubtotal;
        int sublevel = CalSubtotalLevel(subtotal);
        PrintReceipt(wAppleDbl, wBananaDbl, subtotal, sublevel);

    }
    else if(userChoiceStr=="2")
    {

        

        Console.WriteLine($@"
Summary Information:
Total number of orders: {nOrders}
Total weight of apples sold (lbs): {totalAppleW}
Total weight of bananas sold (lbs): {totalBananaW}
Sum of subtotals: {sumOfSubtotal:C2}
Average Subtotal: {sumOfSubtotal / nOrders:C2}
Subtotal level 1: {sublevel1Count}/{nOrders} ({sublevel1Count/nOrders:P2})
Subtotal level 2: {sublevel2Count}/{nOrders} ({sublevel2Count/nOrders:P2})
Subtotal level 3: {sublevel3Count}/{nOrders} ({sublevel3Count/nOrders:P2})
");




    }
    else
    {
        Console.WriteLine("Thank you and goodbye!");
        break;

    }









}



