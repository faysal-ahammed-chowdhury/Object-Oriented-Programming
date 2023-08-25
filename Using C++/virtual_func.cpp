#include <bits/stdc++.h>
using namespace std;

class Parent
{
public:
    virtual void print()
    {
        cout << "Parent\n";
    }
};

class Child : public Parent
{
public:
    void print()
    {
        cout << "Child\n";
    }
    void say_hi()
    {
        cout << "Hi\n";
    }
};

int main()
{
    // Parent p;
    // p.print();

    // Child c;
    // c.print();

    Child c;
    Parent *p = &c;
    c.print();
    p->print();
    // p->say_hi();

    return 0;
}
