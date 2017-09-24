# Basket_API

Documentation Basket API 

 
The purpose of this API was to provide a basket web API that allow the customers to manage their basket, the functions that the basket web API should have is the customer to be able to add new items into the basket and have the option to be able to change the quantity of the items, in addition customers should be able to remove items from the basket. 

Functions
The functions that were implemented into the API are adding items, changing the quantity of the items and items can be removed from the basket. The items are stored as an object in memory when the API is running which contains the ID, Name and quantity of each item in the basket. 

How these functions are implemented are by using HTTP method of Post, Put and Delete while using HTTP Get to display items that are in the basket.  How these HTTP methods are used is by item’s ID that each items have, this method is used to find the item that the user want to change or to remove from the basket.  

Both update and delete function require the item’s id to be included in the HTTP in order to find the item in the basket, if it is not able to find the item then an error would appear.  For instance the HTTP /api/Basket/1 would allow the function to find the item that has the item’s ID of “1”. 

Some of the functions that can be improved would be the delete function, reason for this is that the customer would have to remove the item individually instead of removing all of the items from the basket, this because the delete function use ID to allow the customer to remove individual items instead of removing all. 

Part 2 client library

Due to technical difficulties I am unable to complete the task of creating a client library to have access to the basket web API, reason for this is that the visual studio that I’m using is unable to install the packages that is required to create the client library. 
The package that was required was the HTTP client class (System.Net.Http,HttpClient ) which is used to sent HTTP requests and receiving HTTP responses, without this class I’m unable to create a application which is able to send HTTP requests an receive them. Therefore I’m unable to complete part 2. 










