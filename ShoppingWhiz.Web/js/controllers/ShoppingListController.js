'use strict';

shoppingWhiz.controller('ShoppingListController',
    function ShoppingListController($scope, $location, shoppingListService) {
        
        $scope.lists = [];

        $scope.addItem = function() {
            $location.url('/newItem');
        };

        $scope.deleteItem = function(item) {
            for(var i = 0; i < $scope.items.length; i++) {
                if($scope.items[i].id === item.id) {
                    $scope.items.splice(i, 1);
                    break;
                }     
            }
        };

        $scope.saveItem = function() {
            var item = $scope.item;
            if(item) {
                if(item.store && item.total) {
                    item.id = nextId();
                    $scope.items.push(item);
                    $location.url('/');
                }    
            }    
        };

        $scope.editItem = function(item) {
            
        };

        function nextId() {
            return $scope.items.length + 1; 
        }

        //$scope.items = [
        //    {
        //        id: 1,
        //        store: 'Ica',
        //        total: 287
        //    },
        //    {
        //        id: 2,
        //        store: 'Willys',
        //        total: 95
        //    },
        //    {
        //        id: 3,
        //        store: 'Coop',
        //        total: 501
        //    },
        //    {
        //        id: 4,
        //        store: 'Lidl',
        //        total: 403
        //    },
        //    {
        //        id: 5,
        //        store: 'Willys',
        //        total: 900
        //    },
        //    {
        //        id: 6,
        //        store: 'Coop',
        //        total: 560
        //    }
        //];        
    }
); 