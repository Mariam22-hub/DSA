#ifndef PHONEDIRECTORY_H
#define PHONEDIRECTORY_H

#include <iostream>
#include <bits/stdc++.h>
#include <string>
#include <vector>

using namespace std;

class PhoneDirectory {

private:

    string first_name;
    string last_name;
    string phone;

public:

    PhoneDirectory(){};
    
    friend istream& operator >> (istream &is, PhoneDirectory &obj);
    friend ostream& operator << (ostream &os, const PhoneDirectory &obj);
    
    bool deleteContact(string first);
    
    void set_firstName ( string n );
    void set_lastName ( string n );
    
    string get_firstName();
    string get_lastName();
    string get_phone();
    
    bool search_name(string n);
    bool search_number(string n);
    friend void Sort(vector<PhoneDirectory> vec);

};

#endif // PHONEDIRECTORY_H
