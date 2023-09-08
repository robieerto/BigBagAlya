<template>
	<h1 id="tableLabel">Záznamy Big bag</h1>

	<p v-if="!records"><em>Loading...</em></p>

	<table class='table table-striped' aria-labelledby="tableLabel" v-if="records">
		<thead>
			<tr>
				<th>Id</th>
				<th>Zariadenie číslo</th>
				<th>Program číslo</th>
				<th>Užívateľ číslo</th>
				<th>Váha</th>
				<th>Čas</th>
			</tr>
		</thead>
		<tbody>
			<tr v-for="record of records" v-bind:key="record">
				<td>{{ record.id }}</td>
				<td>{{ record.zariadenieCislo }}</td>
				<td>{{ record.programCislo }}</td>
				<td>{{ record.uzivatelCislo }}</td>
				<td>{{ record.vaha }}</td>
				<td>{{ new Date(record.cas).toLocaleString('sk-SK') }}</td>
			</tr>
		</tbody>
	</table>
</template>


<script>
	import axios from 'axios'
	export default {
		name: "FetchData",
		data() {
			return {
				records: []
			}
		},
		methods: {
			getRecords() {
				axios.get('/zaznamy')
					.then((response) => {
						this.records = response.data;
						console.log(this.records);
					})
					.catch(function (error) {
						alert(error);
					});
			}
		},
		mounted() {
			this.getRecords();
		}
	}
</script>