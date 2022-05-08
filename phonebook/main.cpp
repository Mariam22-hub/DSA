#include <iostream>
#include <bits/stdc++.h>
#include <string>
#include <vector>
#include "PhoneDirectory.h"

using namespace std;




int main(){

    int choice{};
    vector <PhoneDirectory> records;

    cout << "-------------------------------------------------------"<< endl;
    cout << "1. ADD AN ENTRY" << endl;
    cout << "2. LOOK UP RECORD BY PHONE NUMBER" << endl;
    cout << "3. LOOK UP RECORD BY FIRST NAME" << endl;
    cout << "4. DELETE AN ENTRY" << endl;
    cout << "5. LIST ALL ENTRIES IN DIRECTORY" << endl;
    cout << "6. EXIT" << endl;
    cout << "-------------------------------------------------------"<< endl;

    int count{0};
    cout << "please choose from 1 to 6 " << endl;

    while ( cin >> choice ) {

        if ( choice == 1 ) {
            cout << "please enter directory details" << endl;
            PhoneDirectory newentry;
            cin >> newentry;
            records.push_back(newentry);
            count ++;
        }

        if ( choice == 2 ){
            string num;
            int flag{0};
            cout << "please enter the phone number of record" << endl;
            cin >> num;
            for ( int i{0}; i<records.size(); i++ ) {
                if ( records[i].get_phone() == num ) {
                    flag = 1;
                    if ( records[i].search_number(num)){
                        cout << records[i];
                        break;
                    }
                }
            }
            if ( flag != 1){
                cout << "record doesn't exist" << endl;
            }
        }

        if ( choice == 3 ) {
            string name;
            int flag{0};
            cout << "please enter the first name of record" << endl;
            cin >> name;
            for ( int i{0}; i<records.size(); i++ ) {
                if ( records[i].get_firstName() == name ) {
                    flag = 1;
                    if ( records[i].search_name(name)){
                        cout << records[i];
                        break;
                    }
                }
            }
            if ( flag != 1){
                cout << "record doesn't exist" << endl;
            }

        }

        if ( choice == 4 ) {
            cout << "enter first name of contact to be deleted: " << endl;
            string name;
            cin >> name;
            int flag{0};

            for ( int i{0}; i<records.size(); i++ ) {
                if (records[i].get_firstName() == name){
                    flag = 1;
                    if (records[i].deleteContact(name)){
                        records.erase(records.begin()+i);
                        cout << "record deleted successfully!" << endl;
                        break;
                    }
                }
            }
            if ( flag != 1 ) {
                cout << "record doesn't exist" << endl;
            }
        }

        if ( choice == 5 ) {
            

            cout << "There are " << count << " Entries" << endl;
            cout << endl;
            Sort(records);
        }
        

        if ( choice == 6 ) {
            cout << "program is exited" << endl;
            return 0;
        }


        cout << endl;
        cout << "please choose from 1 to 6 " << endl;

    }

}
