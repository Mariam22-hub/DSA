#include "PhoneDirectory.h"

    void PhoneDirectory :: set_firstName ( string n ) {
        first_name = n;
    }

    void PhoneDirectory :: set_lastName ( string n ) {
        last_name = n;
    }

    string PhoneDirectory :: get_firstName(){
        return first_name;
    }
    string PhoneDirectory :: get_lastName(){
        return last_name;
    }
    string PhoneDirectory :: get_phone(){
        return phone;
    }
    
    bool PhoneDirectory::deleteContact(string first){
    if ( first == first_name ) {
        first_name.erase();
        last_name.erase();
        phone.erase();
        return 1;
    }
    return 0;
}

bool PhoneDirectory:: search_name(string n){
    if ( n == first_name) {
        return 1;
    }
    return 0;
}

bool PhoneDirectory :: search_number(string n){
    if ( n == phone) {
        return 1;
    }
    return 0;
}


istream& operator >> (istream &is, PhoneDirectory &obj){
    cout << "First Name: ";
    is >> obj.first_name;

    cout << "last Name: ";
    is >> obj.last_name;

    cout << "Phone Number: ";
    is >> obj.phone;

    return is;
}

ostream& operator << (ostream &os, const PhoneDirectory &obj){
    cout << "Full Name: ";
    os << obj.first_name << " " << obj.last_name<< endl;

    cout << "Phone Number: ";
    os << obj.phone << endl;

    return os;
}



void Sort(vector<PhoneDirectory> vec){

    for(int gap = vec.size()/2; gap>0; gap/=2){
        for ( int j=gap; j<vec.size(); j++ ){
            int i=0;
            char temp = vec[j].first_name[0];
            PhoneDirectory temp2 = vec[j];
            for ( i=j; i >= gap && vec[i-gap].first_name[0] > temp; i = i-gap){
                vec[i] = vec[i-gap];
            }
            vec[i] = temp2;
        }
    }

    for (int i{0}; i<vec.size(); i++ ) {
        cout << vec[i] << endl;
    }
}

