#include <bits/stdc++.h>
using namespace std;

class A
{
private:
    int num;

public:
    static int count;
    void show()
    {
        cout << count++ << endl;
    }

    static void print(int num);
};

int A::count = 0;

// void A::print(int num)
// {
//     this->num = num;
//     cout << this->num << endl;
// }

int main()
{
    A a1, a2;
    a1.show();
    a1.show();
    a2.show();
    a2.show();
    a1.show();
    cout << a2.count << endl;
    cout << a1.count << endl;
    // a1.print(5);
    // a2.print(10);

    // A::print(5);

    return 0;
}
