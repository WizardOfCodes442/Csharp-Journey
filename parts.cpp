//parts.cpp
//use parts inventories to demonstrate structures
#include <iostream>
using namespace std;

/////////////////////////////////////////////////////
struct part             //declare a structure
{
    int modelnumber;        // ID of the widget
    int partnumber;         //ID number of widget part
    float cost;             // cost of part

};

//////////////////////////////////////////////////////
int main()
{
    part part1;               //define a structure variable 
    part1.modelnumber = 6244;  // give values to structure member
    part1.partnumber = 373; 
    part1.cost = 217.55F;

    cout << "Model"  << part1.modelnumber;
    cout << ", part" << part1.partnumber;
    cout << ", cost $" << part1.cost << endl; 

}