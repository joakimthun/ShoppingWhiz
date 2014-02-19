'use strict';

var shoppingWhiz = angular.module('shoppingWhiz', ['ngRoute', 'ngResource']);

shoppingWhiz.config(function ($routeProvider, $locationProvider) {
    $routeProvider
        .when('/',
            {
                controller: 'AccountController',
                templateUrl: 'js/templates/login.html'
            })
        .when('/signup',
            {
                controller: 'AccountController',
                templateUrl: 'js/templates/signup.html'
            })
        .when('/shoppingList',
            {
                controller: 'ShoppingListController',
                templateUrl: 'js/templates/shoppingList.html'
            })
        .when('/newItem',
            {
                controller: 'ShoppingListController',
                templateUrl: 'js/templates/newPurchase.html'
            })
        .otherwise({ redirectTo: '/' });

        //$locationProvider.html5Mode(true);
    });