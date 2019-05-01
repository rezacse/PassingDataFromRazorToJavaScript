var APP = {};
(function (plugin) {

    function init(model) {
        var persons = JSON.parse(model);

        var url = '/PMO/ChangeLog/ChangeLogsAjax';
        $('#personContainer').DataTable({
            data: persons,
            processing: true,
            paging: false,
            searching: false,
            //"ajax": {
            //    "url": url,
            //    "type": "POST",
            //    "datatype": "json",
            //    'contentType': 'application/json',
            //    "data": function (d) {
            //        d.ProjectId = parseInt($('#ProjectId').val());
            //        d.Status = parseInt($('#Status').val());

            //        return JSON.stringify(d);
            //    }
            //},
            columns: [
                { data: 'Id', title: 'ID' },
                { data: 'Name', title: 'Name' },
                { data: 'Email', title: 'Email' },
                { data: 'PhoneNumber', title: 'Phone No.'},
            ]
        });
    }

    plugin.init = init;
})(APP);