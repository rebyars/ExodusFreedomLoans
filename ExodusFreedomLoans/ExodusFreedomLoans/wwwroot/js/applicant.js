var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            "url": "/partner/applicant/GetAll",
            "type": "GET",
            "datatype": "json"
        },
        "columns": [
            { "data": "applicantName", "width": "50%" },
            { "data": "applicantName", "width": "25%" },
            {
                "data": "applicantKey",
                "render": function (data) {
                    return `<div class="text-center>
                            <a href="/Partner/applicant/Upsert/${data}" class='btn btn-success text-white' style='cursor:pointer; width 100px;'>
                                <i class = 'fas fa-edit'></i> Edit </a>
                            </div>

                    `;
                }, "width": "25%"
            },

        ],
        "language": {
            "emptyTable": "No previous applicants found."
        },
        "width":"100%"
    });
}