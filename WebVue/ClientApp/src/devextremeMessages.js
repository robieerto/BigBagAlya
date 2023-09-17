import { loadMessages, locale } from "devextreme/localization";

export function localizeMessages(lang) {
    locale(lang);
}

export const dxMessages = {
    sk: {
        Yes: "\u00C1no",
        No: "Nie",
        Cancel: "Zru\u0161i\u0165",
        Clear: "Zmaza\u0165",
        Done: "Hotovo",
        Loading: "Nahr\u00E1vanie...",
        Select: "V\u00FDber...",
        Search: "H\u013eada\u0165",
        Back: "Nasp\u00E4\u0165",
        OK: "Ok",
        "dxCollectionWidget-noDataText": "\u017Diadne d\u00E1ta k zobrazeniu",
        "dxDropDownEditor-selectLabel": "V\u00FDber",
        "validation-required": "povinn\xe9",
        "validation-required-formatted": "{0} je povinn\xfdch",
        "validation-numeric": "Hodnota mus\u00ED by\u0165 \u010D\u00EDslo",
        "validation-numeric-formatted": "{0} mus\u00ED by\u0165 \u010D\u00EDslo",
        "validation-range": "Hodnota je mimo rozsah",
        "validation-range-formatted": "{0} je mimo rozsah",
        "validation-stringLength": "D\u013A\u017Eka textu nie je spr\u00E1vna",
        "validation-stringLength-formatted": "D\u013A\u017Eka textu {0} nie je spr\u00E1vna",
        "validation-custom": "Neplatn\xe1 hodnota",
        "validation-custom-formatted": "{0} je neplatn\xfdch",
        "validation-async": "Neplatn\xe1 hodnota",
        "validation-async-formatted": "{0} je neplatn\xfdch",
        "validation-compare": "Hodnoty sa nezhoduj\u00FA",
        "validation-compare-formatted": "{0} sa nezhoduje",
        "validation-pattern": "Hodnota nezodpoved\u00E1 vzoru",
        "validation-pattern-formatted": "{0} nezodpoved\u00E1 vzoru",
        "validation-email": "Neplatn\xfd email",
        "validation-email-formatted": "{0} nie je platn\u00FD",
        "validation-mask": "Hodnota nie je platn\u00E1",
        "dxLookup-searchPlaceholder": "Minim\u00E1lny po\u010Det znakov: {0}",
        "dxList-pullingDownText": "St\xe1hn\u011bte dol\u016f pro obnoven\xed...",
        "dxList-pulledDownText": "Uvoln\u011bte pro obnoven\xed...",
        "dxList-refreshingText": "Vyhľadávanie...",
        "dxList-pageLoadingText": "Nahr\xe1v\xe1m...",
        "dxList-nextButtonText": "V\xedce",
        "dxList-selectAll": "Vybra\u0165 v\u0161etko",
        "dxListEditDecorator-delete": "zmaza\u0165",
        "dxListEditDecorator-more": "Viacej",
        "dxScrollView-pullingDownText": "Stiahnite dole pro obnovenie...",
        "dxScrollView-pulledDownText": "Uvolnite pre obnovenie...",
        "dxScrollView-refreshingText": "Obnovujem...",
        "dxScrollView-reachBottomText": "Nahr\xe1vam...",
        "dxDateBox-simulatedDataPickerTitleTime": "Vyberte \u010das",
        "dxDateBox-simulatedDataPickerTitleDate": "Vyberte d\u00e1tum",
        "dxDateBox-simulatedDataPickerTitleDateTime": "Vyberte d\u00e1tum a \u010das",
        "dxDateBox-validation-datetime": "Hodnota mus\u00ED by\u0165 d\u00E1tum a \u010Das",
        "dxFileUploader-selectFile": "Vyberte s\u00FAbor",
        "dxFileUploader-dropFile": "alebo presu\u0148te s\u00FAbor sem",
        "dxFileUploader-bytes": "bytov",
        "dxFileUploader-kb": "kb",
        "dxFileUploader-Mb": "Mb",
        "dxFileUploader-Gb": "Gb",
        "dxFileUploader-upload": "Nahra\u0165",
        "dxFileUploader-uploaded": "Nahrat\u00E9",
        "dxFileUploader-readyToUpload": "Pripraven\u00E9 k nahratiu",
        "dxFileUploader-uploadAbortedMessage": "TODO",
        "dxFileUploader-uploadFailedMessage": "Nahr\u00E1vanie zlyhalo",
        "dxFileUploader-invalidFileExtension": "Nezn\u00E1ma pr\u00EDpona s\u00FAboru",
        "dxFileUploader-invalidMaxFileSize": "",
        "dxFileUploader-invalidMinFileSize": "",
        "dxRangeSlider-ariaFrom": "Od",
        "dxRangeSlider-ariaTill": "Do",
        "dxSwitch-switchedOnText": "ZAP",
        "dxSwitch-switchedOffText": "VYP",
        "dxForm-optionalMark": "voliteln\xfd",
        "dxForm-requiredMessage": "{0} je povinn\u00E9",
        "dxNumberBox-invalidValueMessage": "Hodnota mus\u00ED by\u0165 \u010D\u00EDslo",
        "dxNumberBox-noDataText": "\u017Diadne d\u00E1ta",
        "dxDataGrid-columnChooserTitle": "V\u00FDber s\u013Apcov",
        "dxDataGrid-columnChooserEmptyText": "Peesu\u0148te st\u013Epec sem pre skytie",
        "dxDataGrid-groupContinuesMessage": "Pokra\u010Dova\u0165 na nasleduj\u00FAcej strane",
        "dxDataGrid-groupContinuedMessage": "Pokra\u010Dovanie z predch\u00E1dzaj\u00FAcej strany",
        "dxDataGrid-groupHeaderText": "Zl\u00FA\u010Di\u0165 st\u013Apce",
        "dxDataGrid-ungroupHeaderText": "Oddeli\u0165",
        "dxDataGrid-ungroupAllText": "Oddeli\u0165 v\u0161etko",
        "dxDataGrid-editingEditRow": "Upravi\u0165",
        "dxDataGrid-editingSaveRowChanges": "Ulo\u017ei\u0165",
        "dxDataGrid-editingCancelRowChanges": "Zru\u0161i\u0165",
        "dxDataGrid-editingDeleteRow": "Zmaza\u0165",
        "dxDataGrid-editingUndeleteRow": "Obnovi\u0165",
        "dxDataGrid-editingConfirmDeleteMessage": "Naozaj chcete zmaza\u0165 tento z\xe1znam?",
        "dxDataGrid-validationCancelChanges": "Zru\u0161i\u0165 zmeny",
        "dxDataGrid-groupPanelEmptyText": "Presu\u0148te hlavi\u010Dku st\u013Apca tu pre zl\u00FA\u010Denie",
        "dxDataGrid-noDataText": "\u017Diadne d\u00E1ta",
        "dxDataGrid-searchPanelPlaceholder": "H\u013Eadanie...",
        "dxDataGrid-filterRowShowAllText": "(V\u0161etko)",
        "dxDataGrid-filterRowResetOperationText": "Reset",
        "dxDataGrid-filterRowOperationEquals": "Rovn\xe1 sa",
        "dxDataGrid-filterRowOperationNotEquals": "Nerovn\xe1 sa",
        "dxDataGrid-filterRowOperationLess": "Men\u0161ie",
        "dxDataGrid-filterRowOperationLessOrEquals": "Men\u0161ie alebo rovn\u00E9",
        "dxDataGrid-filterRowOperationGreater": "V\u00E4\u010D\u0161ie",
        "dxDataGrid-filterRowOperationGreaterOrEquals": "V\u00E4\u010D\u0161ie alebo rovn\u00E9",
        "dxDataGrid-filterRowOperationStartsWith": "Za\u010D\u00EDna na",
        "dxDataGrid-filterRowOperationContains": "Obsahuje",
        "dxDataGrid-filterRowOperationNotContains": "Neobsahuje",
        "dxDataGrid-filterRowOperationEndsWith": "Kon\u010d\xed na",
        "dxDataGrid-filterRowOperationBetween": "Medzi",
        "dxDataGrid-filterRowOperationBetweenStartText": "Za\u010d\xedna",
        "dxDataGrid-filterRowOperationBetweenEndText": "Kon\u010d\xed",
        "dxDataGrid-applyFilterText": "Pou\u017E\u00ED\u0165 filter",
        "dxDataGrid-trueText": "\u00C1no",
        "dxDataGrid-falseText": "Nie",
        "dxDataGrid-sortingAscendingText": "Zoradi\u0165 vzostupne",
        "dxDataGrid-sortingDescendingText": "Zoradi\u0165 zostupne",
        "dxDataGrid-sortingClearText": "Zru\u0161i\u0165 zoradenie",
        "dxDataGrid-editingSaveAllChanges": "Ulo\u017Ei\u0165 zmeny",
        "dxDataGrid-editingCancelAllChanges": "Zru\u0161i\u0165 zmeny",
        "dxDataGrid-editingAddRow": "Prida\u0165 riadok",
        "dxDataGrid-summaryMin": "Min: {0}",
        "dxDataGrid-summaryMinOtherColumn": "Min {1} je {0}",
        "dxDataGrid-summaryMax": "Max: {0}",
        "dxDataGrid-summaryMaxOtherColumn": "Max {1} je {0}",
        "dxDataGrid-summaryAvg": "Priemer: {0}",
        "dxDataGrid-summaryAvgOtherColumn": "Priemer z {1} je {0}",
        "dxDataGrid-summarySum": "Suma: {0}",
        "dxDataGrid-summarySumOtherColumn": "Suma {1} je {0}",
        "dxDataGrid-summaryCount": "Po\u010det: {0}",
        "dxDataGrid-columnFixingFix": "Uchyti\u0165",
        "dxDataGrid-columnFixingUnfix": "Uvolni\u0165",
        "dxDataGrid-columnFixingLeftPosition": "V\u013Eavo",
        "dxDataGrid-columnFixingRightPosition": "Vpravo",
        "dxDataGrid-exportTo": "Export",
        "dxDataGrid-exportToExcel": "Export do Excel-u",
        "dxDataGrid-exporting": "Export...",
        "dxDataGrid-excelFormat": "s\u00FAbor Excel",
        "dxDataGrid-selectedRows": "Vybran\u00E9 riadky",
        "dxDataGrid-exportSelectedRows": "Export vybran\u00FDch riadkov",
        "dxDataGrid-exportAll": "Exportova\u0165 v\u0161etky z\u00E1znamy",
        "dxDataGrid-headerFilterEmptyValue": "(pr\u00E1zdne)",
        "dxDataGrid-headerFilterOK": "Ok",
        "dxDataGrid-headerFilterCancel": "Zru\u0161i\u0165",
        "dxDataGrid-ariaColumn": "St\u013Apec",
        "dxDataGrid-ariaValue": "Hodnota",
        "dxDataGrid-ariaFilterCell": "Filtrova\u0165 bunku",
        "dxDataGrid-ariaCollapse": "Zbali\u0165",
        "dxDataGrid-ariaExpand": "Rozbali\u0165",
        "dxDataGrid-ariaDataGrid": "Datov\u00E1 mrie\u017Eka",
        "dxDataGrid-ariaSearchInGrid": "H\u013Eada\u0165 v datovej mrie\u017Eke",
        "dxDataGrid-ariaSelectAll": "Vybra\u0165 v\u0161etko",
        "dxDataGrid-ariaSelectRow": "Vybra\u0165 riadok",
        "dxDataGrid-filterBuilderPopupTitle": "Tvorba Filtra",
        "dxDataGrid-filterPanelCreateFilter": "Vytvori\u0165 Filter",
        "dxDataGrid-filterPanelClearFilter": "Zmaza\u0165",
        "dxDataGrid-filterPanelFilterEnabledHint": "Povoli\u0165 Filter",
        "dxTreeList-ariaTreeList": "Strom",
        "dxTreeList-editingAddRowToNode": "Prida\u0165",
        "dxPager-infoText": "Strana {0} z {1} ({2} polo\u017eiek)",
        "dxPager-pagesCountText": "z",
        "dxPager-pageSizesAllText": "V\u0161etko",
        "dxPivotGrid-grandTotal": "Celkom",
        "dxPivotGrid-total": "{0} Celkom",
        "dxPivotGrid-fieldChooserTitle": "V\u00FDber po\u013Ea",
        "dxPivotGrid-showFieldChooser": "Zobrazi\u0165 v\u00FDber po\u013Ea",
        "dxPivotGrid-expandAll": "Rozbali\u0165 v\u0161etko",
        "dxPivotGrid-collapseAll": "Zbalit v\u0161etko",
        "dxPivotGrid-sortColumnBySummary": 'Zoradi\u0165 "{0}" pod\u013Ea tohoto st\u013Apca',
        "dxPivotGrid-sortRowBySummary": 'Zoradi\u0165 "{0}" pod\u013Ea tohoto riadku',
        "dxPivotGrid-removeAllSorting": "Odstranit ve\u0161ker\xe9 t\u0159\xedd\u011bn\xed",
        "dxPivotGrid-dataNotAvailable": "nedostupn\xe9",
        "dxPivotGrid-rowFields": "Pole \u0159\xe1dk\u016f",
        "dxPivotGrid-columnFields": "Pole sloupc\u016f",
        "dxPivotGrid-dataFields": "Pole dat",
        "dxPivotGrid-filterFields": "Filtrovat pole",
        "dxPivotGrid-allFields": "V\u0161echna pole",
        "dxPivotGrid-columnFieldArea": "Zde vlo\u017ete pole sloupc\u016f",
        "dxPivotGrid-dataFieldArea": "Zde vlo\u017ete pole dat",
        "dxPivotGrid-rowFieldArea": "Zde vlo\u017ete pole \u0159\xe1dk\u016f",
        "dxPivotGrid-filterFieldArea": "Zde vlo\u017ete filtr pole",
        "dxScheduler-editorLabelTitle": "P\u0159edm\u011bt",
        "dxScheduler-editorLabelStartDate": "Po\u010d\xe1te\u010dn\xed datum",
        "dxScheduler-editorLabelEndDate": "Koncov\xe9 datum",
        "dxScheduler-editorLabelDescription": "Popis",
        "dxScheduler-editorLabelRecurrence": "Opakovat",
        "dxScheduler-openAppointment": "Otev\u0159\xedt sch\u016fzku",
        "dxScheduler-recurrenceNever": "Nikdy",
        "dxScheduler-recurrenceMinutely": "Minutely",
        "dxScheduler-recurrenceHourly": "Hourly",
        "dxScheduler-recurrenceDaily": "Denn\u011b",
        "dxScheduler-recurrenceWeekly": "T\xfddn\u011b",
        "dxScheduler-recurrenceMonthly": "M\u011bs\xed\u010dn\u011b",
        "dxScheduler-recurrenceYearly": "Ro\u010dn\u011b",
        "dxScheduler-recurrenceRepeatEvery": "Ka\u017ed\xfd",
        "dxScheduler-recurrenceRepeatOn": "Repeat On",
        "dxScheduler-recurrenceEnd": "Konec opakov\xe1n\xed",
        "dxScheduler-recurrenceAfter": "Po",
        "dxScheduler-recurrenceOn": "Zap",
        "dxScheduler-recurrenceRepeatMinutely": "minute(s)",
        "dxScheduler-recurrenceRepeatHourly": "hour(s)",
        "dxScheduler-recurrenceRepeatDaily": "dn\xed",
        "dxScheduler-recurrenceRepeatWeekly": "t\xfddn\u016f",
        "dxScheduler-recurrenceRepeatMonthly": "m\u011bs\xedc\u016f",
        "dxScheduler-recurrenceRepeatYearly": "rok\u016f",
        "dxScheduler-switcherDay": "Den",
        "dxScheduler-switcherWeek": "T\xfdden",
        "dxScheduler-switcherWorkWeek": "Pracovn\xed t\xfdden",
        "dxScheduler-switcherMonth": "M\u011bs\xedc",
        "dxScheduler-switcherAgenda": "Agenda",
        "dxScheduler-switcherTimelineDay": "\u010casov\xe1 osa den",
        "dxScheduler-switcherTimelineWeek": "\u010casov\xe1 osa t\xfdden",
        "dxScheduler-switcherTimelineWorkWeek": "\u010casov\xe1 osa pracovn\xed t\xfdden",
        "dxScheduler-switcherTimelineMonth": "\u010casov\xe1 osa m\u011bs\xedc",
        "dxScheduler-recurrenceRepeatOnDate": "na den",
        "dxScheduler-recurrenceRepeatCount": "v\xfdskyt\u016f",
        "dxScheduler-allDay": "Cel\xfd den",
        "dxScheduler-confirmRecurrenceEditMessage": "Chcete upravit pouze tuto sch\u016fzku nebo celou s\xe9rii?",
        "dxScheduler-confirmRecurrenceDeleteMessage": "Chcete smazat pouze tuto sch\u016fzku nebo celou s\xe9rii?",
        "dxScheduler-confirmRecurrenceEditSeries": "Upravit s\xe9rii",
        "dxScheduler-confirmRecurrenceDeleteSeries": "Smazat s\xe9rii",
        "dxScheduler-confirmRecurrenceEditOccurrence": "Upravit sch\u016fzku",
        "dxScheduler-confirmRecurrenceDeleteOccurrence": "Smazat sch\u016fzku",
        "dxScheduler-noTimezoneTitle": "Bez \u010dasov\xe9 z\xf3ny",
        "dxScheduler-moreAppointments": "{0} nav\xedc",
        "dxCalendar-todayButtonText": "Dnes",
        "dxCalendar-ariaWidgetName": "Kalend\u00e1r",
        "dxColorView-ariaRed": "\u010cerven\xe1",
        "dxColorView-ariaGreen": "Zelen\xe1",
        "dxColorView-ariaBlue": "Modr\xe1",
        "dxColorView-ariaAlpha": "Prieh\u013Eadn\u00E1",
        "dxColorView-ariaHex": "K\xf3d farvy",
        "dxTagBox-selected": "{0} vybran\u00E9",
        "dxTagBox-allSelected": "V\u0161etko vybran\u00E9 ({0})",
        "dxTagBox-moreSelected": "{0} naviac",
        "vizExport-printingButtonText": "Tla\u010D",
        "vizExport-titleMenuText": "Export/import",
        "vizExport-exportButtonText": "{0} s\u00FAborov",
        "dxFilterBuilder-and": "A",
        "dxFilterBuilder-or": "ALEBO",
        "dxFilterBuilder-notAnd": "NAND",
        "dxFilterBuilder-notOr": "NOR",
        "dxFilterBuilder-addCondition": "Prida\u0165 podmienku",
        "dxFilterBuilder-addGroup": "Prida\u0165 skupinu",
        "dxFilterBuilder-enterValueText": "<vlo\u017ete hodnotu>",
        "dxFilterBuilder-filterOperationEquals": "Rovn\xe1 sa",
        "dxFilterBuilder-filterOperationNotEquals": "Nerovn\xe1 sa",
        "dxFilterBuilder-filterOperationLess": "Men\u0161ie ako",
        "dxFilterBuilder-filterOperationLessOrEquals": "Men\u0161ie alebo rovn\u00E9 ako",
        "dxFilterBuilder-filterOperationGreater": "V\u00E4\u010D\u0161ie ako",
        "dxFilterBuilder-filterOperationGreaterOrEquals": "V\u00E4\u010D\u0161ie alebo rovn\u00E9 ako",
        "dxFilterBuilder-filterOperationStartsWith": "Za\u010D\u00EDna na",
        "dxFilterBuilder-filterOperationContains": "Obsahuje",
        "dxFilterBuilder-filterOperationNotContains": "Neobsahuje",
        "dxFilterBuilder-filterOperationEndsWith": "Kon\u010d\xed na",
        "dxFilterBuilder-filterOperationIsBlank": "Je pr\xe1zdne",
        "dxFilterBuilder-filterOperationIsNotBlank": "Nie je pr\u00E1zdne",
        "dxFilterBuilder-filterOperationBetween": "Medzi",
        "dxFilterBuilder-filterOperationAnyOf": "\u013Dubovoln\u00FD z",
        "dxFilterBuilder-filterOperationNoneOf": "\u017Diadny z",
        "dxHtmlEditor-dialogColorCaption": "!TODO!",
        "dxHtmlEditor-dialogBackgroundCaption": "!TODO!",
        "dxHtmlEditor-dialogLinkCaption": "!TODO!",
        "dxHtmlEditor-dialogLinkUrlField": "!TODO!",
        "dxHtmlEditor-dialogLinkTextField": "!TODO!",
        "dxHtmlEditor-dialogLinkTargetField": "!TODO!",
        "dxHtmlEditor-dialogImageCaption": "!TODO!",
        "dxHtmlEditor-dialogImageUrlField": "!TODO!",
        "dxHtmlEditor-dialogImageAltField": "!TODO!",
        "dxHtmlEditor-dialogImageWidthField": "!TODO!",
        "dxHtmlEditor-dialogImageHeightField": "!TODO!",
        "dxHtmlEditor-dialogInsertTableRowsField": "!TODO",
        "dxHtmlEditor-dialogInsertTableColumnsField": "!TODO",
        "dxHtmlEditor-dialogInsertTableCaption": "!TODO",
        "dxHtmlEditor-heading": "!TODO!",
        "dxHtmlEditor-normalText": "!TODO!",
        "dxFileManager-newDirectoryName": "TODO",
        "dxFileManager-rootDirectoryName": "TODO",
        "dxFileManager-errorNoAccess": "TODO",
        "dxFileManager-errorDirectoryExistsFormat": "TODO",
        "dxFileManager-errorFileExistsFormat": "TODO",
        "dxFileManager-errorFileNotFoundFormat": "TODO",
        "dxFileManager-errorDirectoryNotFoundFormat": "TODO",
        "dxFileManager-errorWrongFileExtension": "TODO",
        "dxFileManager-errorMaxFileSizeExceeded": "TODO",
        "dxFileManager-errorInvalidSymbols": "TODO",
        "dxFileManager-errorDefault": "TODO",
        "dxFileManager-errorDirectoryOpenFailed": "TODO",
        "dxDiagram-categoryGeneral": "TODO",
        "dxDiagram-categoryFlowchart": "TODO",
        "dxDiagram-categoryOrgChart": "TODO",
        "dxDiagram-categoryContainers": "TODO",
        "dxDiagram-categoryCustom": "TODO",
        "dxDiagram-commandExportToSvg": "TODO",
        "dxDiagram-commandExportToPng": "TODO",
        "dxDiagram-commandExportToJpg": "TODO",
        "dxDiagram-commandUndo": "TODO",
        "dxDiagram-commandRedo": "TODO",
        "dxDiagram-commandFontName": "TODO",
        "dxDiagram-commandFontSize": "TODO",
        "dxDiagram-commandBold": "TODO",
        "dxDiagram-commandItalic": "TODO",
        "dxDiagram-commandUnderline": "TODO",
        "dxDiagram-commandTextColor": "TODO",
        "dxDiagram-commandLineColor": "TODO",
        "dxDiagram-commandLineWidth": "TODO",
        "dxDiagram-commandLineStyle": "TODO",
        "dxDiagram-commandLineStyleSolid": "TODO",
        "dxDiagram-commandLineStyleDotted": "TODO",
        "dxDiagram-commandLineStyleDashed": "TODO",
        "dxDiagram-commandFillColor": "TODO",
        "dxDiagram-commandAlignLeft": "TODO",
        "dxDiagram-commandAlignCenter": "TODO",
        "dxDiagram-commandAlignRight": "TODO",
        "dxDiagram-commandConnectorLineType": "TODO",
        "dxDiagram-commandConnectorLineStraight": "TODO",
        "dxDiagram-commandConnectorLineOrthogonal": "TODO",
        "dxDiagram-commandConnectorLineStart": "TODO",
        "dxDiagram-commandConnectorLineEnd": "TODO",
        "dxDiagram-commandConnectorLineNone": "TODO",
        "dxDiagram-commandConnectorLineArrow": "TODO",
        "dxDiagram-commandFullscreen": "TODO",
        "dxDiagram-commandUnits": "TODO",
        "dxDiagram-commandPageSize": "TODO",
        "dxDiagram-commandPageOrientation": "TODO",
        "dxDiagram-commandPageOrientationLandscape": "TODO",
        "dxDiagram-commandPageOrientationPortrait": "TODO",
        "dxDiagram-commandPageColor": "TODO",
        "dxDiagram-commandShowGrid": "TODO",
        "dxDiagram-commandSnapToGrid": "TODO",
        "dxDiagram-commandGridSize": "TODO",
        "dxDiagram-commandZoomLevel": "TODO",
        "dxDiagram-commandAutoZoom": "TODO",
        "dxDiagram-commandFitToContent": "TODO",
        "dxDiagram-commandFitToWidth": "TODO",
        "dxDiagram-commandAutoZoomByContent": "TODO",
        "dxDiagram-commandAutoZoomByWidth": "TODO",
        "dxDiagram-commandSimpleView": "TODO",
        "dxDiagram-commandCut": "TODO",
        "dxDiagram-commandCopy": "TODO",
        "dxDiagram-commandPaste": "TODO",
        "dxDiagram-commandSelectAll": "TODO",
        "dxDiagram-commandDelete": "TODO",
        "dxDiagram-commandBringToFront": "TODO",
        "dxDiagram-commandSendToBack": "TODO",
        "dxDiagram-commandLock": "TODO",
        "dxDiagram-commandUnlock": "TODO",
        "dxDiagram-commandInsertShapeImage": "TODO",
        "dxDiagram-commandEditShapeImage": "TODO",
        "dxDiagram-commandDeleteShapeImage": "TODO",
        "dxDiagram-commandLayoutLeftToRight": "TODO",
        "dxDiagram-commandLayoutRightToLeft": "TODO",
        "dxDiagram-commandLayoutTopToBottom": "TODO",
        "dxDiagram-commandLayoutBottomToTop": "TODO",
        "dxDiagram-unitIn": "TODO",
        "dxDiagram-unitCm": "TODO",
        "dxDiagram-unitPx": "TODO",
        "dxDiagram-dialogButtonOK": "TODO",
        "dxDiagram-dialogButtonCancel": "TODO",
        "dxDiagram-dialogInsertShapeImageTitle": "TODO",
        "dxDiagram-dialogEditShapeImageTitle": "TODO",
        "dxDiagram-dialogEditShapeImageSelectButton": "TODO",
        "dxDiagram-dialogEditShapeImageLabelText": "TODO",
        "dxDiagram-uiExport": "TODO",
        "dxDiagram-uiProperties": "TODO",
        "dxDiagram-uiSettings": "TODO",
        "dxDiagram-uiShowToolbox": "TODO",
        "dxDiagram-uiSearch": "TODO",
        "dxDiagram-uiStyle": "TODO",
        "dxDiagram-uiLayout": "TODO",
        "dxDiagram-uiLayoutTree": "TODO",
        "dxDiagram-uiLayoutLayered": "TODO",
        "dxDiagram-uiDiagram": "TODO",
        "dxDiagram-uiText": "TODO",
        "dxDiagram-uiObject": "TODO",
        "dxDiagram-uiConnector": "TODO",
        "dxDiagram-uiPage": "TODO",
        "dxDiagram-shapeText": "TODO",
        "dxDiagram-shapeRectangle": "TODO",
        "dxDiagram-shapeEllipse": "TODO",
        "dxDiagram-shapeCross": "TODO",
        "dxDiagram-shapeTriangle": "TODO",
        "dxDiagram-shapeDiamond": "TODO",
        "dxDiagram-shapeHeart": "TODO",
        "dxDiagram-shapePentagon": "TODO",
        "dxDiagram-shapeHexagon": "TODO",
        "dxDiagram-shapeOctagon": "TODO",
        "dxDiagram-shapeStar": "TODO",
        "dxDiagram-shapeArrowLeft": "TODO",
        "dxDiagram-shapeArrowUp": "TODO",
        "dxDiagram-shapeArrowRight": "TODO",
        "dxDiagram-shapeArrowDown": "TODO",
        "dxDiagram-shapeArrowUpDown": "TODO",
        "dxDiagram-shapeArrowLeftRight": "TODO",
        "dxDiagram-shapeProcess": "TODO",
        "dxDiagram-shapeDecision": "TODO",
        "dxDiagram-shapeTerminator": "TODO",
        "dxDiagram-shapePredefinedProcess": "TODO",
        "dxDiagram-shapeDocument": "TODO",
        "dxDiagram-shapeMultipleDocuments": "TODO",
        "dxDiagram-shapeManualInput": "TODO",
        "dxDiagram-shapePreparation": "TODO",
        "dxDiagram-shapeData": "TODO",
        "dxDiagram-shapeDatabase": "TODO",
        "dxDiagram-shapeHardDisk": "TODO",
        "dxDiagram-shapeInternalStorage": "TODO",
        "dxDiagram-shapePaperTape": "TODO",
        "dxDiagram-shapeManualOperation": "TODO",
        "dxDiagram-shapeDelay": "TODO",
        "dxDiagram-shapeStoredData": "TODO",
        "dxDiagram-shapeDisplay": "TODO",
        "dxDiagram-shapeMerge": "TODO",
        "dxDiagram-shapeConnector": "TODO",
        "dxDiagram-shapeOr": "TODO",
        "dxDiagram-shapeSummingJunction": "TODO",
        "dxDiagram-shapeContainerDefaultText": "TODO",
        "dxDiagram-shapeVerticalContainer": "TODO",
        "dxDiagram-shapeHorizontalContainer": "TODO",
        "dxDiagram-shapeCardDefaultText": "TODO",
        "dxDiagram-shapeCardWithImageOnLeft": "TODO",
        "dxDiagram-shapeCardWithImageOnTop": "TODO",
        "dxDiagram-shapeCardWithImageOnRight": "TODO",
        "dxGantt-dialogTitle": "TODO",
        "dxGantt-dialogStartTitle": "TODO",
        "dxGantt-dialogEndTitle": "TODO",
        "dxGantt-dialogProgressTitle": "TODO",
        "dxGantt-dialogResourcesTitle": "TODO",
        "dxGantt-dialogResourceManagerTitle": "TODO",
        "dxGantt-dialogTaskDetailsTitle": "TODO",
        "dxGantt-dialogEditResourceListHint": "TODO",
        "dxGantt-dialogEditNoResources": "TODO",
        "dxGantt-dialogButtonAdd": "TODO",
        "dxGantt-contextMenuNewTask": "TODO",
        "dxGantt-contextMenuNewSubtask": "TODO",
        "dxGantt-contextMenuDeleteTask": "TODO",
        "dxGantt-contextMenuDeleteDependency": "TODO",
        "dxGantt-dialogTaskDeleteConfirmation": "TODO",
        "dxGantt-dialogDependencyDeleteConfirmation": "TODO",
        "dxGantt-dialogResourcesDeleteConfirmation": "TODO",
        "dxGantt-dialogConstraintCriticalViolationMessage": "TODO",
        "dxGantt-dialogConstraintViolationMessage": "TODO",
        "dxGantt-dialogCancelOperationMessage": "TODO",
        "dxGantt-dialogDeleteDependencyMessage": "TODO",
        "dxGantt-dialogMoveTaskAndKeepDependencyMessage": "TODO",
        "dxGantt-undo": "TODO",
        "dxGantt-redo": "TODO",
        "dxGantt-expandAll": "TODO",
        "dxGantt-collapseAll": "TODO",
        "dxGantt-addNewTask": "TODO",
        "dxGantt-deleteSelectedTask": "TODO",
        "dxGantt-zoomIn": "TODO",
        "dxGantt-zoomOut": "TODO",
        "dxGantt-fullScreen": "TODO",
    },
};

loadMessages(dxMessages);