# 02_Accessor
### We use accessor to Access the private variable in the same class
```
private string strName;
public string Name         #Accessor
{
    get {return strName;}
    set {strName = value;}
}
```
### We use this get line to get the value from our private variable `strName`.

`get {return strName;}`

### We use this set line to assign the value to our private variable `strName`.

`set {strName = value;}`

---

## Example

When we want to assign the value to private variable. 

We have to use its accessor `hObj.Address = Console.ReadLine();`
```
{
      House hObj = new House();
      Console.Write("Enter the address of House");
      hObj.Address = Console.ReadLine(); #1
}
```
