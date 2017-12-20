# .NET 401 - Lab 02
http://codekata.com/kata/kata01-supermarket-pricing/

## Overview
Some things in supermarkets have simple prices: this can of beans costs $0.65. Other things have more complex prices. For example:
- three for a dollar (so what’s the price if I buy 4, or 5?)
- $1.99/pound (so what does 4 ounces cost?)
- buy two, get one free (so does the third item have a price?)

This kata involves no coding. The exercise is to experiment with various models for representing money and prices that are flexible enough to deal 
with these (and other) pricing schemes, and at the same time are generally usable (at the checkout, for stock management, order entry, and so on). 
Spend time considering issues such as:
- does fractional money exist?
- when (if ever) does rounding take place?
- how do you keep an audit trail of pricing decisions (and do you need to)?
- are costs and prices the same class of thing?
- if a shelf of 100 cans is priced using “buy two, get one free”, how do you value the stock?

## Problem Assessment
Unit prices for items can change over time, and this is different from the sale price. Sale price is tied to the transaction that reflects the price at the time.
As the price changes, the sale price will still have been recorded with the price it was at.  If historical price changes need to be tracked as well, that can be 
done as well with the date and time it was changed. Assuming this is being stored in a relational database, it would be another table that links back to the table 
storing the item and current price. Deals and discounts should probably be logic run at checkout time. So if something is 3 for a $1, the final price would be 
modified if there are a total number of that item that is divisible by 3, taking away the difference of the unit price multiplied by 3 and $1. If not, then dividing 
$1 by 3, then adding them up together would result in inconsistancies because you can round only 1 of the items up, and two items would be listed as a different unit 
price as the 3rd item in the series. Buy 2 get 1 free would be treated the same, there would be logic that determines if the total items are divisible by 3, that 
result times the unit price would be subtracted from the subtotal. This way, if only 1 or 2, or even 4 or 5 items are purchased, the unit price would not be cheaper 
for the remaining units. 