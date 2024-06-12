select * from artikel
select * from faskes
select * from jenis_obat
select * from jenis_profil
select * from kalori_makanan
select * from keluhan
select * from obat
select * from penyakit
select * from profil

TRUNCATE artikel;
DELETE FROM artikel;

ALTER TABLE profil
ALTER COLUMN no_telfon 
TYPE varchar(16);

create table obat (
id_obat serial primary key,
nama_obat varchar (64),
fungsi varchar (256),
dosis varchar (256),
id_penyakit serial,
id_jenis serial,
constraint fk_penyakit
	foreign key ("id_penyakit")
	references penyakit ("id_penyakit")
	on delete cascade,
constraint fk_jenis_obat
	foreign key ("id_jenis")
	references jenis_obat ("id_jenis")
	on delete cascade
);

create table artikel (
id_artikel serial primary key,
judul varchar (64) not null,
sumber varchar(128) not null,
id_penyakit serial,
constraint fk_penyakit
	foreign key ("id_penyakit")
	references penyakit ("id_penyakit")
	on delete cascade
);

insert into obat(nama_obat, fungsi, dosis, id_penyakit, id_jenis)
values --(1, 'Procol', 'mengatasi flu dan batuk', '1-2 tablet 2-3 kali sehari', 1, 1 )
		('Amoxcilin', 'mengatasi infeksi bakteri, seperti sakit tenggorokan, diare, bronkitis dan infeksi telinga', '250-500 mg/hari', 16, 1),
		('azithromycin', 'mengobati infeksi ringan hingga sedang, sinus, kulit, pneumonia', '500mg/hari', 8, 2),
		('Carbidu', 'mengatasi peradangan dan reaksi alergi yang berupa gatal-gatal di kulit seperti kolera', '0.5-9 mg/hari', 20, 2),
		('Dexametashon', 'meredakan peradangan, penyakit autoimun, atau radang sendi, dan oesteoporosis', '0,5-0,9 mg/hari', 17, 2),
		('Indapamide', 'menurunkan tekanan darah pada kondisi hipertensi, mengatasi kelebihan cairan tubuh yang menyebabkan pembengkakan (edema) pada pasien gagal jantung', '2,5 mg 1 kali sehari', 12, 5),
		('Clopidogrel Promed', ' mengalami stroke iskemik atau stroke yang disebabkan oleh penyumbatan pembuluh darah otak', '75mg/hari', 13, 5),
		('Sangobion', 'embantu mengatasi anemia saat menstruasi, hamil, menyusui, masa pertumbuhan, dan setelah mengalami pendarahan', '1 capsule/hari', 18, 2),
		('Kaditic', 'mengobati kanker paru-paru dan atau nyeri pascaoperasi', '50mg', 11, 5),
		('Floxigra', 'meredakan tifus', '3-30 gram/hari', 19, 2),
		('Glucophage Tablet','digunakan untuk mengatasi diabetes melitus','500-850mg/hari' , 2, 2),
		('Chlorothiazide', 'meredakan hipertensi', '500-1000mg/dua hari', 3, 2),
		('Pro Tb', 'mengatasi TBC, paru-paru', '5 mg/kg dan 10 mg/kg per hari masing-masing', 4, 3),
		('Doxycycline', 'mengobati malaria', '100mg/hari', 5, 3),
		('Metocloparamide', 'mengobati demam berdarah', '10 mg 3 kali sehari sebelum makan dan sebelum tidur', 6, 2),
		('Nirmatrelvir/ritonavir/paxlovid ', 'mengobati covid 19', '300 mg Nirmatrelvir (dua tablet 150 mg) dan 100 mg Ritonavir (satu tablet) dua kali sehari selama 5 hari', 7, 5),
		('Dolutegravir', 'mengbati hepatitis B', '50 mg sekali sehari', 9, 5),
		('Spironolactone', 'untuk HIV/AIDS', '25-100 mg sekali sehari', 10, 5),
		('Prorenal', 'mengobati sakit ginjal', '1-2 kapsul atau tablet dua kali sehari', 14, 2),
		('Ventolin Expectorant Sirup', 'meredakan asma','10 ml 3-4 kali sehari', 15, 1)

insert into artikel (judul, sumber, id_penyakit)
values --(1, '⁠Diabetes tak pandang usia : Ancaman mengintai semua kalangan', 'https://www.kompasiana.com/nurfadiyahputri9079/664af8f4de948f0939317022/diabetes-tak-pandang-usia-ancaman-mengintai-semua-kalangan' , 2)
		('Mengenal Penyebab Penyakit Hepatitis', 'https://aido.id/health-articles/penyebab-penyakit-hepatitis/detail' , 9),
('Mengatasi Tantangan dalam Perjalanan Eliminasi Malaria: Pelajaran dari Jawa dan Bali', 'https://www.who.int/indonesia/id/news/detail/20-09-2023-overcoming-challenges-on-the-path-to-malaria-elimination--lessons-from-java-and-bali', 5),
('Kasus TBC di Indonesia tembus 1 juta – Kenapa meningkat pada anak dan seperti apa gejalanya?' , 'https://www.bbc.com/indonesia/articles/c3g081vlxlpo', 4),
('Kasus covid di Indonesia meningkat akibat varian baru – Apa gejalanya dan apa saja yang harus diwaspadai?', 'https://www.bbc.com/indonesia/articles/ck7p0jg92gko', 7),
('Alergi hingga stress, ini 13 penyebab asma di sekitar anda', 'https://hellosehat.com/pernapasan/asma/penyebab-asma/' , 15),
('Kasus langka perempuan yang mengenyahkan virus HIV dari tubuhnya tanpa obat', 'https://www.bbc.com/indonesia/majalah-59322010' , 10),
('Berbagai penyebab bronkitis yang perlu anda waspadai', 'https://hellosehat.com/pernapasan/bronkitis/penyebab-bronkitis/' , 16),
('macam penyakit jantung yang paling sering terjadi', 'https://www.klikdokter.com/info-sehat/jantung/macam-macam-penyakit-jantung', 12),
('Kenali gejala tipes ringan hingga parah dan pengobatannya', 'https://hellosehat.com/infeksi/tifus/berbagai-gejala-tipes/', 19),
('Kupas Tuntas Penyakit Stroke, dari Jenis, Gejala, hingga Cara Mengobatinya!', 'https://www.emc.id/id/care-plus/kupas-tuntas-penyakit-stroke-dari-jenis-gejala-hingga-cara-mengobatinya', 13),
('Ketahui Penularan Penyakit Kolera yang Harus Diwaspadai', 'https://www.halodoc.com/artikel/ketahui-penularan-penyakit-kolera-yang-harus-diwaspadai', 20),
('Soalan Lazim – Penyakit Influenza', 'http://www.myhealth.gov.my/soalan-lazim-penyakit-influenza/', 1),
('Penyebab Demam Berdarah', 'https://www.alodokter.com/demam-berdarah/penyebab', 6),
('Edukasi Pentingnya Diet Cairan dan Nutrisi pada Penderita Gagal Ginjal Kronik yang Menjalani Terapi Hemodialisis', 'https://www.researchgate.net/publication/362493716_Edukasi_Pentingnya_Diet_Cairan_dan_Nutrisi_pada_Penderita_Gagal_Ginjal_Kronik_yang_Menjalani_Terapi_Hemodialisis', 14)
