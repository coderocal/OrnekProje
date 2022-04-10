app.controller('PersonelCtrl', function ($scope, $http, $window) {
    $scope.GetPersonel = function () {
        var url = serviceUrl;
        $http.get(url + 'Personel/PersonelListesi')
            .then(function (response) {
                if (response.data.IsSuccess == false) {
                    alert(response.data.Message);
                }
                //alert("oldu");
                $scope.PersonelList = response.data.ResultTable
            });
    }

    $scope.GetPersonel();
});