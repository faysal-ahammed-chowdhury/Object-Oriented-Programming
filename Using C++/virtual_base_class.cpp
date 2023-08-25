#include <bits/stdc++.h>
using namespace std;

class parent
{
protected:
    int p;

public:
    void set(int x)
    {
        p = x;
    }
    void show()
    {
        cout << "parent= " << p << endl;
    }
};

class child1 : public virtual parent
{
protected:
    int c1;
    int p;

public:
    void set(int x)
    {
        c1 = x;
    }
    void show()
    {
        cout << "child1= " << c1 << endl;
    }
};

class child2 : public virtual parent
{
protected:
    int c2;
    int p;

public:
    void set(int y)
    {
        c2 = y;
    }
    void show()
    {
        cout << "child2= " << c2 << endl;
    }
};

class grandchild : virtual public child1, virtual public child2
{
protected:
    int gc;
    int parent::p;

public:
    // int p = parent::p;
    void set(int z)
    {
        gc = z;
    }
    void show()
    {
        cout << "grandchild=" << gc;
        cout << endl;
    }
};

int main()
{
    grandchild gc1;

    gc1.parent::p = 10;
    cout << gc1.p << endl;
    gc1.child1::p = 20;
    cout << gc1.p << endl;
    gc1.child2::p = 30;
    cout << gc1.p << endl;
    gc1.p = 40;
    cout << gc1.p << endl;

    gc1.parent::set(1);
    gc1.parent::show();
    gc1.child1::set(2);
    gc1.child1::show();
    gc1.child2::set(4);
    gc1.child2::show();

    return 0;
}
