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
            url: '/Product/Blogs',
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
            { "data": "title", "name": "title", "autowidth": true },
            { "data": "description", "name": "description", "autowidth": true },
            { "data": "date", "name": "date", "autowidth": true },
            { "data": "imageUrl", "name": "ImageUrl", "autowidth": true },
        ],
    });

});
