# Decorator Design Pattern

[![Donate][link-icon-coffee]][link-paypal-me] [![Website][link-icon-website]][link-website] ![GitHub last commit](https://img.shields.io/github/last-commit/EndMove/dp-decorator)

[link-icon-coffee]: https://img.shields.io/badge/%E2%98%95-Buy%20me%20a%20cup%20of%20coffee-991481.svg
[link-paypal-me]: https://www.paypal.me/EndMove/2.5eur
[link-icon-website]: https://img.shields.io/badge/%F0%9F%92%BB-My%20Web%20Site-0078D4.svg
[link-website]: https://www.endmove.eu/

Used language: `C#`.

## Informations about the DP

The Decorator is a structural design pattern that allows you to dynamically add new behaviours to objects by placing them inside special objects called wrappers (in my case the 'DecoratorBase' objects inheriting from 'Decorator').

Using these decorators, you can wrap objects many times, since the target objects and decorators implement the same interface. The final object will receive all the behaviours of all the wrappers.

## Explanations

In the case of my example we have **BurgerComponent.cs** which is the common base interface (more precisely an abstract class in my case), this interface will be directly implemented by the base object (one of the 3 hamburger types). Then comes the **Decorator.cs** which also implements the **BurgerComponent.cs** interface and which will be extended by the add-ons (fries and mayonnaise) present in **DecoratorBase.cs**.

When a **DecoratorBase** is instantiated, it receives either a 'main' object or a base decorator. They will stack on top of each other.

`BurgerBase01 -> BB01+DecoratorBase01 -> BB01+DB01+DecoratorBase02 => BB01+DB01+DB02`