namespace DelegatesAndEventsPractice.Delegates
{
    class DelegatesIntro
    {
        delegate void DelegateExample(int a);

        void Start()
        {
            Foobar(Foo);
        }

        void Foobar(DelegateExample delegateExample)
        {
            delegateExample(30);
        }

        void Foo(int a)
        {
            // Do something
        }

        void Bar(int a)
        {
            // Do something else
        }
    }
}
