function Calendar(anchor, data) {
    this.now = new Date();
    this.day = this.now.getDate();
    this.month = this.now.getMonth();
    this.year = this.now.getFullYear();
    this.anchor = anchor;
    this.divContainer = null;
    this.divTable = null;
    this.divDateText = null;
    this.divButtons = null;

    this.selectedDay = null;

    this.onDateSelect = function (eventTarget) {
        if (window.innerWidth > 850) {
            var elements = document.querySelectorAll('.row-table');
        }
        else {
            var elements = document.querySelectorAll('.day-table');
        }
        eventTarget.events.forEach(element => {
            const s = document.createElement("section");
            const pHeader = document.createElement("h3");
            const eventMarker = document.createElement("span");
            const p = document.createElement("p");
            const link = document.createElement("a");
            s.classList.add("event-container");
            pHeader.innerHTML = element["name"];
            if (eventTarget.happened == false) {
                eventMarker.classList.add("event-" + element["availableTickets"]);
            }
            else {
                eventMarker.classList.add("event-outdated");
            }
            eventMarker.classList.add("inner-event-marker");
            p.innerHTML = element["overview"];
            link.innerHTML = "Read More";
            link.setAttribute("href", "Flight?="+element["flightId"]);
            if (element["picture"]) {
                const img = document.createElement("div");
                img.style.backgroundImage = "url(" + element["picture"] + ")";
                s.appendChild(img);
            }
            s.appendChild(pHeader);
            s.appendChild(eventMarker);
            s.appendChild(p);
            s.appendChild(link);
            if (window.innerWidth > 850) {
                elements[eventTarget.row - 1].appendChild(s);
            }
            else {
                elements[eventTarget.number].appendChild(s);
            }
        });
        if (window.innerWidth > 850) {
            elements[eventTarget.row - 1].style.display = "flex";
        }
        else {
            elements[eventTarget.number].style.display = "flex";
        }
        this.selectedDay = eventTarget;
        this.selectedDay.classList.add("selected-day");
    }.bind(this)

    this.clearDateSelect = function () {
        var elements = document.querySelectorAll('.flights-table');
        for (let index = 0; index < elements.length; index++) {
            elements[index].style.display = "none";
            elements[index].innerHTML = "";
        }
        if (this.selectedDay != null) {
            this.selectedDay.classList.remove("selected-day");
            this.selectedDay = null;
        }
    }.bind(this)

    this.createButtons = function () {
        const buttonLeft = document.createElement("button");
        const buttonRight = document.createElement("button");
        buttonLeft.innerText = "<";
        buttonRight.innerText = ">";
        buttonLeft.type = "button";
        buttonRight.type = "button";
        buttonLeft.classList.add("arrow");
        buttonRight.classList.add("arrow");
        buttonLeft.addEventListener("click", function () {
            this.month--;
            if (this.month < 0) {
                this.month = 11;
                this.year--;
            }
            this.createCalendarTable();
            this.createDateText();
        }.bind(this));
        buttonRight.addEventListener("click", function () {
            this.month++;
            if (this.month > 11) {
                this.month = 0;
                this.year++;
            }
            this.createCalendarTable();
            this.createDateText();
        }.bind(this));
        this.divButtons.appendChild(buttonLeft);
        this.divButtons.appendChild(buttonRight);
    };

    this.createDateText = function () {
        const monthNames = ["January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"];
        this.divDateText.innerHTML = monthNames[this.month] + ' ' + this.year;
    };

    this.createCalendarTable = function () {
        this.divTable.innerHTML = "";

        const tab = document.createElement("table");
        tab.classList.add("inner-table");

        let monthsRow = document.createElement("div");
        monthsRow.classList.add("months-table")
        const days = ["SUN", "MON", "TUE", "WED", "THU", "FRI", "SAT"];
        for (let i = 0; i < days.length; i++) {
            const monthCell = document.createElement("div");
            monthCell.classList.add("month");
            monthCell.innerHTML = days[i];
            monthsRow.appendChild(monthCell);
        }
        tab.appendChild(monthsRow);

        const daysInMonth = new Date(this.year, this.month + 1, 0).getDate();

        const tempDate = new Date(this.year, this.month, 1);
        let firstMonthDay = tempDate.getDay();

        const j = daysInMonth + firstMonthDay;
        var generatedCells = 0;
        var generatedRows = 0;

        if (firstMonthDay !== 0) {
            row = document.createElement("div");
            eventsCell = document.createElement("div");
            row.classList.add("days-table");
            eventsCell.classList.add("flights-table");
            eventsCell.classList.add("row-table");
            tab.appendChild(row);
            generatedRows++;
            tab.appendChild(eventsCell);
        }

        var offset = 0;
        for (let i = 0; i < firstMonthDay; i++) {
            const cell = document.createElement("div");
            cell.classList.add("empty-day-container");
            cell.innerHTML = "";
            row.appendChild(cell);
            generatedCells++;
            offset++;
        }

        for (let i = firstMonthDay; i < j; i++) {
            if ((i % 7) == 0) {
                row = document.createElement("div");
                eventsCell = document.createElement("div");
                row.classList.add("days-table");
                eventsCell.classList.add("flights-table");
                eventsCell.classList.add("row-table");
                tab.appendChild(row);
                generatedRows++;
                tab.appendChild(eventsCell);
            }

            const cell = document.createElement("div");
            const day = document.createElement("div");
            const events = document.createElement("div");
            const eventsTab = document.createElement("div");
            day.innerText = i - firstMonthDay + 1;;
            events.dayNr = i - firstMonthDay + 1;
            cell.dayNr = i - firstMonthDay + 1;
            cell.eventsInDay = 0;
            cell.events = [];
            cell.number = generatedCells - offset;
            cell.row = generatedRows;
            cell.classList.add("day-container");
            cell.happened = true;
            day.classList.add("day");
            events.classList.add("events");
            eventsTab.classList.add("flights-table");
            eventsTab.classList.add("day-table");

            if (this.year === this.now.getFullYear() && this.month === this.now.getMonth() && this.day === i - firstMonthDay + 1) {
                cell.classList.add("today");
            }

            var concatenatedDate = this.year + "-";
            if ((this.month + 1) < 10) {
                concatenatedDate += "0" + (this.month + 1) + "-";
            }
            else {
                concatenatedDate += (this.month + 1) + "-";
            }
            if ((i - firstMonthDay + 1) < 10) {
                concatenatedDate += "0" + (i - firstMonthDay + 1);
            }
            else {
                concatenatedDate += (i - firstMonthDay + 1);
            }
            for (let index = 0; index < data.length; index++) {
                if (data[index]["date"] == concatenatedDate) {
                    if (cell.eventsInDay < 3) {
                        const event = document.createElement("span");
                        if (this.now.getFullYear() > this.year) {
                            event.classList.add("event-outdated");
                        }
                        else if (this.now.getMonth() > this.month && this.now.getFullYear() == this.year) {
                            event.classList.add("event-outdated");
                        }
                        else if (i - firstMonthDay + 1 < this.day && this.now.getMonth() == this.month && this.now.getFullYear() == this.year) {
                            event.classList.add("event-outdated");
                        }
                        else {
                            event.classList.add("event-" + data[index]["availableTickets"]);
                            cell.happened = false;
                        }
                        events.appendChild(event);
                    }
                    cell.eventsInDay++;
                    cell.events.push(data[index]);
                }
            }

            if (cell.eventsInDay > 3) {
                const additionalEventsMarker = document.createElement("span");
                additionalEventsMarker.classList.add("additional-events-marker");
                events.appendChild(additionalEventsMarker);
            }

            cell.appendChild(day);
            generatedCells++;
            cell.appendChild(events);
            row.appendChild(cell);
            row.appendChild(eventsTab);
        }

        for (let i = generatedCells; i < 35; i++) {
            const cell = document.createElement("div");
            cell.classList.add("empty-day-container");
            cell.innerHTML = "";
            row.appendChild(cell);
        }

        tab.appendChild(row);
        tab.appendChild(eventsCell);

        this.divTable.appendChild(tab);
    };

    this.selectDay = function (e, eventTarget) {
        if (eventTarget.classList.contains("day-container")) {
            if (eventTarget.eventsInDay > 0) {
                this.clearDateSelect();
                this.onDateSelect(eventTarget)
                e.stopPropagation();
            }
        }
    }.bind(this)

    this.bindTableDaysEvent = function () {
        this.divTable.addEventListener("click", function (e) {
            this.selectDay(e, e.target.parentElement.parentElement);
            this.selectDay(e, e.target.parentElement);
            this.selectDay(e, e.target);
        }.bind(this));

        document.addEventListener("click", function (e) {
            if (!e.target.classList.contains("flights-table") &&
                !e.target.parentElement.classList.contains("flights-table") &&
                !e.target.parentElement.parentElement.classList.contains("flights-table")) {
                this.clearDateSelect()
            }
        }.bind(this));
    }

    this.init = function () {
        this.divContainer = document.createElement("div");

        this.divButtons = document.createElement("div");
        this.divButtons.className = "arrow-bar";
        this.createButtons();

        this.divDateText = document.createElement("div");
        this.divDateText.className = "date-text";
        this.createDateText();

        this.divHeader = document.createElement("div");
        this.divHeader.classList.add("calendar-header");

        this.divHeader.appendChild(this.divButtons);
        this.divHeader.appendChild(this.divDateText);
        this.divContainer.appendChild(this.divHeader);

        this.divTable = document.createElement("div");
        this.divContainer.appendChild(this.divTable);
        this.createCalendarTable();
        this.bindTableDaysEvent();

        this.anchor.appendChild(this.divContainer);
    };
};

//var data = {
//    "flights": [
//        { "date": "3-4-2018", "name": "eventOne", "description": "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quibusdam deserunt quae, beatae esse incidunt voluptatum iste, aliquam error, necessitatibus molestias excepturi facere quia non. Esse, animi eaque. Aliquam, quasi quas. ", "flightLink": "Flight?id=1", "img-url": "/images/n1.jpg", "available tickets": "low" },
//        { "date": "3-4-2018", "name": "eventOne", "description": "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quibusdam deserunt quae, beatae esse incidunt voluptatum iste, aliquam error, necessitatibus molestias excepturi facere quia non. Esse, animi eaque. Aliquam, quasi quas. ", "flightLink": "Flight?id=1", "img-url": "/images/n1.jpg", "available tickets": "medium" },
//        { "date": "3-4-2018", "name": "eventOne", "description": "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quibusdam deserunt quae, beatae esse incidunt voluptatum iste, aliquam error, necessitatibus molestias excepturi facere quia non. Esse, animi eaque. Aliquam, quasi quas.  ", "flightLink": "Flight?id=1", "img-url": "/images/n1.jpg", "available tickets": "low" },
//        { "date": "4-4-2018", "name": "eventOne", "description": "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quibusdam deserunt quae, beatae esse incidunt voluptatum iste, aliquam error, necessitatibus molestias excepturi facere quia non. Esse, animi eaque. Aliquam, quasi quas. ", "flightLink": "Flight?id=1", "img-url": "/images/n1.jpg", "available tickets": "high" },
//        { "date": "4-4-2018", "name": "eventOne", "description": "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quibusdam deserunt quae, beatae esse incidunt voluptatum iste, aliquam error, necessitatibus molestias excepturi facere quia non. Esse, animi eaque. Aliquam, quasi quas.  ", "flightLink": "Flight?id=1", "img-url": "/images/n1.jpg", "available tickets": "medium" },
//        { "date": "2-4-2018", "name": "eventOne", "description": "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quibusdam deserunt quae, beatae esse incidunt voluptatum iste, aliquam error, necessitatibus molestias excepturi facere quia non. Esse, animi eaque. Aliquam, quasi quas. ", "flightLink": "Flight?id=1", "img-url": "/images/n1.jpg", "available tickets": "low" },
//        { "date": "2-4-2018", "name": "eventOne", "description": "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quibusdam deserunt quae, beatae esse incidunt voluptatum iste, aliquam error, necessitatibus molestias excepturi facere quia non. Esse, animi eaque. Aliquam, quasi quas.  ", "flightLink": "flight.html", "img-url": "/images/n1.jpg", "available tickets": "low" },
//        { "date": "2-4-2018", "name": "eventOne", "description": "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quibusdam deserunt quae, beatae esse incidunt voluptatum iste, aliquam error, necessitatibus molestias excepturi facere quia non. Esse, animi eaque. Aliquam, quasi quas. ", "img-url": "images/n1.jpg", "available tickets": "high" },
//        { "date": "2-4-2018", "name": "eventOne", "description": "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quibusdam deserunt quae, beatae esse incidunt voluptatum iste, aliquam error, necessitatibus molestias excepturi facere quia non. Esse, animi eaque. Aliquam, quasi quas.  ", "img-url": "images/n1.jpg", "available tickets": "low" },
//        { "date": "1-4-2018", "name": "eventOne", "description": "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quibusdam deserunt quae, beatae esse incidunt voluptatum iste, aliquam error, necessitatibus molestias excepturi facere quia non. Esse, animi eaque. Aliquam, quasi quas. ", "img-url": "images/n1.jpg", "available tickets": "low" },
//        { "date": "7-4-2018", "name": "eventOne", "description": "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quibusdam deserunt quae, beatae esse incidunt voluptatum iste, aliquam error, necessitatibus molestias excepturi facere quia non. Esse, animi eaque. Aliquam, quasi quas.  ", "img-url": "images/n1.jpg", "available tickets": "low" },
//        { "date": "11-4-2018", "name": "eventTwo", "available tickets": "medium" },
//        { "date": "11-4-2018", "name": "eventThree", "available tickets": "low" },
//        { "date": "15-4-2018", "name": "eventThree", "available tickets": "high" },
//        { "date": "15-4-2018", "name": "eventThree", "available tickets": "medium" },
//        { "date": "21-4-2018", "name": "eventThree", "available tickets": "medium" },
//        { "date": "22-4-2018", "name": "eventThree", "available tickets": "high" },
//        { "date": "22-4-2018", "name": "eventThree", "available tickets": "high" },
//        { "date": "22-4-2018", "name": "eventThree", "available tickets": "medium" },
//        { "date": "3-5-2018", "name": "eventThree", "available tickets": "medium" },
//        { "date": "5-5-2018", "name": "eventThree", "available tickets": "low" },
//    ]
//}

fetch('data').then(response => {
    return response.json();
}).then(data => {
    document.getElementById("loader").style.display = "none";
    const anchor = document.querySelector('#app-container');
    const cal = new Calendar(anchor, data);
    cal.init();
});
