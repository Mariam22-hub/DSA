#include <iostream>
#include <bits/stdc++.h>
#include <vector>
#include <cstdlib> 
#include <algorithm>
#include <chrono>
#include <iomanip>

using namespace std;
using namespace std::chrono;

class Sorter {
    
public:
    Sorter(){};
    
    virtual void Sort(vector<int> &vec, int size){}

    virtual ~Sorter(){}
  
};

class SelectionSorter : public Sorter{
public:
    
    virtual void Sort (vector<int> &vec, int size){
        for ( int i{0}; i < size-1; i++ ) {
         int min{i};
         
         for ( int j{i+1}; j < size; j++ ) {
             if ( vec[j] < vec[min] ) {
                 min = j;
             }
        }
        if ( min !=i ) {
            int temp = vec[min];
            vec[min]=vec[i];
            vec[i] = temp;
        }
     } 
    }
    
    virtual ~SelectionSorter(){}
};

class QuickSorter : public Sorter{

public:

    virtual ~QuickSorter(){}
    
    void quickSort(vector<int> &vec, int s, int e){
        if(s<e){
            int p = Partition(vec,s, e);
            quickSort(vec, s, (p-1));  // recursive QS call for left partition
            quickSort(vec, (p+1), e);  // recursive QS call for right partition
        }
    }
    
    int Partition(vector<int> &vec, int s, int e){
            int pivot = vec[e];
            int pIndex = s;
 
            for(int i = s;i<e;i++)
            {
                if(vec[i]<pivot)
                {
                    int temp = vec[i];
                    vec[i] = vec[pIndex];
                    vec[pIndex] = temp;
                    pIndex++;
                }  
            }
 
            int temp = vec[e];
            vec[e] = vec[pIndex];
            vec[pIndex] = temp;
 
            return pIndex;
    }
    
    
    virtual void Sort (vector<int> &vec, int size){
        quickSort(vec, 0, size-1);
    }
 
};


class Testbed {

    Sorter *sorted;
     long long time;

public:
    vector<int> numbers;
 
    Testbed(){};
    
    double get_time(){
        return time;
    }
    
    
    void GenerateRandomList(int min, int max, int size){
        for (int i{0}; i<size; i++){
            numbers.push_back(rand() % ( max - min + 1 ) + min);
        }
    }
    
    void GenerateReverseOrderedList ( int min, int max, int size){
        GenerateRandomList(min, max, size);
           // sort(numbers.begin(), numbers.end(), greater <>());
        for (int i = 1; i < size; i++){
        
            int key = numbers[i];
            int j = i - 1;
            while (key > numbers[j] && j >= 0){
            
                numbers[j + 1] = numbers[j];
                --j;
            }
            
            numbers[j + 1] = key;
        }
        
    }
    
    long long RunOnce(Sorter *t, vector<int> &v , int size){    //to calculate running time
    
         auto start = high_resolution_clock::now();
     
        t->Sort(v, size);
        auto stop = high_resolution_clock::now();
        
        auto seconds = duration_cast<microseconds>(stop - start);
       
        time = seconds.count();
        return time;
    }
    
    long long RunAndAverage ( Sorter *s, int type, int min , int max, int size, int sets_nums){   //calculate average time of sets_num
         long long total{0};
         long long average;
        
        if ( type == 0 ) {  //random
            for ( int i{1}; i<=sets_nums; i++ ) {
                GenerateRandomList(min, max, size);
                total += RunOnce(s, numbers, size);
                numbers.clear();
            }
        }
        else if ( type == 1 ) {   //reversed sorted
            for ( int i{1}; i<=sets_nums; i++ ) {
                GenerateReverseOrderedList(min, max, size);
                total += RunOnce(s, numbers, size);
                numbers.clear();
            }
        }
 
        average = total/sets_nums;    //average time in milliseconds
        return average/1000;
    } 
    
    
    void RunExperiment (Sorter *s, int type, int min, int max, int min_val, int max_val, int sets_num, int step){
        
        for ( int i{step}; i<=max_val; i+=step){
            if ( type == 0 ) {  //random sorted
                cout << i << setw(45) << RunAndAverage(s, 0, min, max, i, sets_num) << " Milliseconds" << endl;
            }
            else if ( type == 1) {   //reverse sorted
                cout << i << setw(45) << RunAndAverage(s, 1, min, max, i, sets_num) << " Milliseconds" << endl;
            }
        }
    }
    
    
};

int main(){
    
    Testbed t;
    
    Sorter *m = new SelectionSorter();
    cout<<"SELECTION SORT : "<< endl;
    
    cout<<"--------------------"<<endl;
    
    cout << endl;
    cout << "SIZE" << setw(56) << "Average Time" << endl; 
    
    cout<<"----------------------------------------------------------------------"<<endl;
    
    t.RunExperiment( m,0, 100, 1100000, 100, 10000, 5, 1000);
    
    cout << endl;
    cout << "Reverse Sorted" << endl;
    cout<<"------------------"<<endl;
    
    t.RunExperiment(m, 1, 100, 1100000, 100, 10000, 5, 1000);
    
    cout<<"---------------------------------------------------------------------------"<<endl;
    
    Testbed s;
    Sorter *n = new QuickSorter();
    cout<<"QUICK SORT : "<< endl;
    cout<<"--------------------"<<endl;
    
    cout << endl;
    cout << "SIZE" << setw(56) << "Average Time" << endl;
    
    cout<<"----------------------------------------------------------------------"<<endl;
    
    s.RunExperiment(n, 0, 100, 1100000, 100, 10000, 5, 1000);
    
    cout << endl;
    cout << "Reverse sorted" << endl;
    cout<<"------------------"<<endl;
    
    s.RunExperiment(n, 1, 100, 1100000, 100, 10000, 5, 1000);
 
}



