# 02_Accessor
### We use accessor to Access the private variable in the same class
```
private string strAddress;
public string Address         #Accessor
{
    get {return strAddress;}
    set {strAddress = value;}
}
```
### We use this get line to get the value from our private variable `strAddress`.

`get {return strAddress;}`

### We use this set line to assign the value to our private variable `strAddress`.

`set {strAddress = value;}`

---

## Example

```
{
      House hObj = new House();
      Console.Write("Enter the address of House");
      hObj.Address = Console.ReadLine(); #1
      Console.WriteLine("Address = {0},hObj.Address);#2
}
```

#1 When we want to assign the value to private variable. We have to use its accessor `hObj.Address = Console.ReadLine();`

By doing this the line `set {strAddress = value;}` will run and the value will go directly to our private variable `strAddress`

#2 When we display the value out, we still use accessor `hObj.Address`.

By doing this the line `get {return strAddress;}` will run and the accessor will retrive the value from private variable `strAddress`

---
# SUM
## Private variable need aceessor with the keywords *get & set* 
## Accessor doesn't store any value, instead it function like a waiter.

