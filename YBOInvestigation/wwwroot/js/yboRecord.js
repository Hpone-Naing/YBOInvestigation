function FillYBSTypesByYBSCompany(lstYBSCompanyCtrl, lstYBSTypeId) {

    var lstYBSTypes = $("#" + lstYBSTypeId);
    lstYBSTypes.empty();

    var selectedYBSCompany = lstYBSCompanyCtrl.options[lstYBSCompanyCtrl.selectedIndex].value;

    if (selectedYBSCompany != null && selectedYBSCompany != '') {
        $.getJSON("/YBORecord/GetYBSTypeByYBSCompanyId", { ybsCompanyId: selectedYBSCompany }, function (ybsTypes) {
            if (ybsTypes != null && !jQuery.isEmptyObject(ybsTypes)) {
                $.each(ybsTypes, function (index, ybsType) {
                    lstYBSTypes.append($('<option/>',
                        {
                            value: ybsType.value,
                            text: ybsType.text
                        }));
                });
            };
        });
    }

    return;
}

function FillDriverLicenseByDriverName(lstDriverName, driverLicenseId) {

    var driverLicenseTestBox = $("#" + driverLicenseId);
    driverLicenseTestBox.empty();
    var selectedDriverName = lstDriverName.options[lstDriverName.selectedIndex].value;

    if (selectedDriverName != null && selectedDriverName != '') {
        $.getJSON("/YBORecord/GetDriverLicenseByDriverName", { driverName: selectedDriverName }, function (driverLicense) {
            driverLicenseTestBox.val(driverLicense);
        });
    }

    return;
}


$(document).ready(function () {

    var alertBox = $(".alert");

    if (alertBox.length > 0) {
        setTimeout(function () {
            alertBox.fadeOut(500);
        }, 3000);
    }
});

$(document).ready(function () {
    $('#add').click(function () {
        $('#lstDriverNameDiv').hide();
        $('#add').hide();
        $('#driverLicenseLbl').show();
        $('#driverNameLbl').show();

        $('#newDriverDiv').show();
        $('#remove').show();
        $('#driverLicense').prop('readonly', false);
        $('#driverLicense').val('');
        $('#newDriverName').val('');
    });

    $('#remove').click(function () {
        $('#lstDriverNameDiv').show();
        $('#lstDriverName').prop('selectedIndex', 0);
        $('#add').show();
        $('#newDriverDiv').hide();
        $('#remove').hide();
        $('#driverLicenseLbl').hide();
        $('#driverNameLbl').hide();
        $('#driverLicense').prop('readonly', true);
    });
});

