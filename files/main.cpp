
#include <bits/stdc++.h>
#include <fstream>



using namespace std;

class FloatArray{

protected:
    int size;
    float *arr;
    int num_of_elements;
    static int count1;

public:

    FloatArray(){};  //default constructor

    FloatArray(int s){      //parameterized constructor
        size = s;
        arr = new float[size];
    }


    virtual void add (float n) {          //insert elements function
        arr[count1] = n;
        count1++;
    }

    virtual void erase_count() {     //erase count function

        num_of_elements = count1;
        count1 = 0;
    }

    int get_size(){         //getter size of array function
        return count1;
    }


    //input operator
    friend ifstream& operator >> (ifstream &readfromfile, FloatArray &obj) {
        float nn;
        readfromfile >> nn;
        obj.add(nn);

        return readfromfile;
    }


    //output operator
    friend ostream& operator << (ostream& readtofile, FloatArray &obj)
    {
        for(int i=0; i<obj.num_of_elements; i++)
        {
            readtofile  << "\t" << obj.arr[i];
        }
        return readtofile;
    }

    ~FloatArray(){        //destructor
        delete [] arr;
    }


};

int FloatArray :: count1 = 0;     //static variable initialization



class SortedArray : public FloatArray {

protected:
    int s;
    static int count2;

public:

    SortedArray (int n):FloatArray(n) {}     //constructor

    virtual void add (float n) {     //insert elements in array
        arr[count2] = n;
        count2++;
    }

    virtual int get_size(){    //getter array size
        return count2;
    }

    virtual void erase_count(){         //erase count
        num_of_elements = count2;
        count2 = 0;
    }

        virtual void add_sort_array (float n) {     //sort array function
        float key;
        int j;

        for (int i = 1; i < n; i++)
        {
            key = arr[i];
            j = i - 1;

            while (j >= 0 && arr[j] < key)
            {
                arr[j + 1] = arr[j];
                j = j - 1;
            }
            arr[j + 1] = key;
        }
    }

    virtual void reverseArray(int start, int endd)      //reverse array function
    {
        while (start < endd)
        {
            float temp = arr[start];
            arr[start] = arr[endd];
            arr[endd] = temp;
            start++;
            endd--;
        }
    }

    ~SortedArray () {     //destructor
        delete [] arr;
    }

};

int SortedArray :: count2 = 0;     //static variable initialization

class FrontArray : public FloatArray {

protected:
    int ss;
    static int count3;

public:

    FrontArray(int c) : FloatArray(c){}     //constructor

    virtual void add (float n) {          //insert elements
        arr[count3] = n;
        count3++;
    }

    virtual int get_size(){       //getter array size
        return count3;
    }

    virtual void erase_count(){           //erase count
        num_of_elements = count3;
        count3 = 0;
    }

    virtual void reverseArray(int start, int endd)              //reverse array function
    {
        while (start < endd)
        {
            float temp = arr[start];
            arr[start] = arr[endd];
            arr[endd] = temp;
            start++;
            endd--;
        }
    }

    ~FrontArray () {       //destructor
        delete [] arr;
    }

};

int FrontArray :: count3 = 0;     //static variable initialization

class PositiveArray : public SortedArray{

protected:
    int sizze;
    static int count4;

public:

    PositiveArray(int s) : SortedArray (s){}  //constructor

    virtual void add (float n) {       //insert elements function with positivity condition
        if ( n>0 ) {
            arr[count4] = n;
            count4++;
        }
    }

    virtual int get_size(){    //getter array size
        return count4;
    }

    virtual void erase_count(){     //erase count
        num_of_elements = count4;
        count4 = 0;
    }

    ~PositiveArray () {       //destructor
        delete [] arr;
    }


};

int PositiveArray :: count4 = 0;     //static variable initialization

class NegativeArray : public SortedArray{

protected:
    int sz;
    static int count5;

public:

    NegativeArray(int s) : SortedArray (s){}       // parameterized constructr

    virtual void add (float n) {     //insert elements function with negativity condition
        if ( n<0 ) {
            arr[count5] = n;
            count5++;
        }
    }

    virtual int get_size(){     //getter array size
        return count5;
    }

    virtual void erase_count(){       //erase count
        num_of_elements = count5;
        count5 = 0;
    }

    ~NegativeArray () {       //destructor
        delete [] arr;
    }
};

int NegativeArray :: count5 = 0;     //static variable initialization


int main() {

    ifstream intxt("in.txt");     //open input file
    ofstream outxt("out.txt");     //open output file

    string in_file, out_file, type;
    int elements_number;


    cout << "Enter the name of the input file:" << endl;
    cin >> in_file;
    cout << "Enter the name of the output file:" << endl;
    cin >> out_file;

    for ( int i{0}; i<10; i++ ) {      //looping over all 10 lines

        intxt >> type >> elements_number;

        if ( type == "Array" ) {          //type condition
            FloatArray floatt(elements_number);

            for ( int i{0}; i < elements_number; i++ ) {
                intxt >> floatt;
            }
            floatt.erase_count();

            outxt << elements_number<<"|";
            outxt << floatt;
            outxt << endl;

        }

        if ( type == "Sorted" ) {
            SortedArray sorted(elements_number);

            for ( int i{0}; i < elements_number; i++ ) {
                intxt >> sorted;
            }
            sorted.add_sort_array(sorted.get_size());
            sorted.reverseArray(0, sorted.get_size() - 1);

            outxt << sorted.get_size()<<"|";
            sorted.erase_count();
            outxt << sorted;
            outxt << endl;

        }

        if ( type == "Front" ) {
            FrontArray fronted(elements_number);

            for ( int i{0}; i < elements_number; i++ ) {
                intxt >> fronted;
            }
            fronted.reverseArray(0, fronted.get_size() - 1);

            outxt << fronted.get_size()<<"|";
            fronted.erase_count();
            outxt << fronted;
            outxt << endl;

        }
        if ( type == "Positive" ) {
            PositiveArray positive(elements_number);

            for ( int i{0}; i < elements_number; i++ ) {
                intxt >> positive;
            }
            positive.add_sort_array(positive.get_size());
            positive.reverseArray(0, positive.get_size()-1);

            outxt << positive.get_size()<<"|";
            positive.erase_count();
            outxt << positive;
            outxt << endl;

        }

        if ( type == "Negative" ) {
            NegativeArray negative(elements_number);

            for ( int i{0}; i < elements_number; i++ ) {
                intxt >> negative;
            }
            negative.add_sort_array(negative.get_size());
            negative.reverseArray(0, negative.get_size()-1);

            outxt << negative.get_size()<<"|";
            negative.erase_count();
            outxt << negative;
            outxt << endl;

        }
    }

}

