$(document).ready(function () {
    UserAction();

    $("#btn_add").click(function () {
        var r = confirm("Are you sure you want to save now?");
        if (r === true) {
            $.ajax({
                url: "http://127.0.0.1:53547/api/dbSave",
                type: "POST",
                success: function (result) {
                    if (result !== 0) {
                        UserAction();
                    }
                    else {
                        alert("Transaction Failed!");
                    }

                }
            });
        }
        else {
            return false;
        }
    });
});

function UserAction() {
    $.ajax({
        url: "http://127.0.0.1:53547/api/dbList",
        type: "GET",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            $('#tbl-list').dataTable({
                "destroy": true,
                "aaData": result,
                "aoColumns": [
                    { "mDataProp": "CurrentTimeQueryId" },
                    { "mDataProp": "Time" },
                    { "mDataProp": "ClientIp" },
                    { "mDataProp": "UTCTime" }
                ],
                "scrollX": true,
                "aaSorting": [[0, 'desc']],
                "searching": false
            });
        }
    });
}