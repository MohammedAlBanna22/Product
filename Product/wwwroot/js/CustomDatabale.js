////$(document).ready(function () {
////    debugger;
////    setTimeout(() => {
////        $('#Customers').DataTable({
////            "processing": true,
////            "serverSide": true,
////            "filter": true,
////            "ajax": {
////                "url": "/Product/Product",
////                "type": "POST",
////                "datatype": "json",
////            },
////            "columnDefs": [{
////                "targets": [0],
////                "visible": false,
////                "searchable": false
////            }],
////            "columns": [
////                { "data": "id", "name": "id", "autowidth": true },
////                { "data": "productName", "name": "productName", "autowidth": true },
////                { "data": "productDescription", "name": "productDescription", "autowidth": true },
////                { "data": "productDate", "name": "productDate", "autowidth": true },
////                { "data": "epireDate", "name": "epireDate", "autowidth": true },
////                { "data": "price", "name": "price", "autowidth": true },
////                { "data": "imageUrl", "name": "imageUrl", "autowidth": true },
////                //{
////                //    "render": function (data, type, row) { return '<span>' + row.dateOfBirth.split('T')[0] + '</span>' },
////                //    "name": "DateOfBirth"
////                //},
////                //{
////                //    "render": function (data, type, row) { return '<a href="#" class="btn btn-danger" onclick=DeleteCustomer("' + row.id + '"); > Delete </a>' },
////                //    "orderable": false
////                //},

////            ]
////        });
////        $('#Customers').DataTable().draw();
////    }, 500);
////});











$(document).ready(function () {

    $('#Customers').DataTable({
        "ordering": false,//To Remove Sorting
        "processing": true,
        "serverSide": true,
        "responsive": true,
        "search": true,
      
        //Disable Search From Table
        /*dom: '<"row"lr><"row"<"col-xs-12 col-lg-12"t>><"row"<"col-sm-6"i><"col-sm-6"p>>',*/
        language: {
            "infoFiltered": ""
        },//To Remove Filter From Footer
        ajax: {
            //url: 'https://preview.keenthemes.com/metronic/theme/html/tools/preview/api/datatables/demos/server.php',
            url: '/Product/Product',
            type: 'POST',
            dataType: "json",
        },
        columnDefs: [{
            "targets": [0],
            "visible": false,
            "searchable": false
        }],
        columns: [
            { "data": "id", "name": "id", "autowidth": true },// data the first letter  must be small
            { "data": "productName", "name": "productName", "autowidth": true },
            { "data": "productDescription", "name": "productDescription", "autowidth": true },
            { "data": "productDate", "name": "productDate", "autowidth": true },
            { "data": "epireDate", "name": "epireDate", "autowidth": true },
            { "data": "price", "name": "price", "autowidth": true },
            { "data": "imageUrl", "name": "imageUrl", "autowidth": true }
        ],
    });

});