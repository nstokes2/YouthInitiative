var YouthInitiative = angular.module('YouthInitiative', ['ui.router', 'ui.bootstrap']);

YouthInitiative.controller('LandingPageController', LandingPageController);

//ZooAngular.factory('AuthHttpResponseInterceptor', AuthHttpResponseInterceptor);

var configFunction = function ($stateProvider, $httpProvider, $locationProvider) {



    $locationProvider.hashPrefix('!').html5Mode(true);



    $stateProvider
       .state('stateOne', {
           url: '/stateOne',
           views: {
               "containerOne": {
                   templateUrl: '/WebPosts/Index'
               },
               "containerTwo": {
                   templateUrl: '/VideoUrls/Index'
               }
           }
       })
           .state('stateTwo',
           {
               url: '/stateTwo',
               views: {
                   "containerOne": {
                       templateUrl: '/WebPosts/Create'
                   },
                   "containerTwo": { templateUrl: '/WebPosts/Index' }
               }


           })
                   .state('stateFour',
           {
               url: '/stateFour',
               views: {
                   "containerThree": {
                       templateUrl: '/VideoUrls/Index'
                   }
                   
               }


           })
                   .state('stateThree',
           {
               url: '/stateThree',
               views: {
                   "containerOne": {
                       templateUrl: '/VideoUrls/Create'
                   },
                   "containerTwo": { templateUrl: '/VideoUrls/Index' }
               }


           })

  

};



//  $httpProvider.interceptors.push('AuthHttpResponseInterceptor');


configFunction.$inject = ['$stateProvider', '$httpProvider', '$locationProvider'];
YouthInitiative.config(configFunction);









