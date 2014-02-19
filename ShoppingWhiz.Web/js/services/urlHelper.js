'use strict';

shoppingWhiz.factory('urlHelper', function() {
        var apiUrl = 'http://shoppingwhizapi.azurewebsites.net';

        return {
            getRequestUrl: function(route) {
                return apiUrl + route;
            }
        };
});