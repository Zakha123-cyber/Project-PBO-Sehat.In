create table penyakit (
id_penyakit serial primary key,
nama_penyakit varchar (256)
);

create table artikel (
id_artikel serial primary key,
judul varchar (256) not null,
sumber varchar(256) not null,
penyakit_id serial,
constraint fk_penyakit
	foreign key ("penyakit_id")
	references penyakit ("id_penyakit")
	on delete cascade
);

create table jenis_obat (
id_jenis serial primary key,
jenis varchar (256)
);

create table obat (
id_obat serial primary key,
nama_obat varchar (256),
fungsi varchar (256),
dosis varchar (256),
penyakit_id serial,
jenis_id serial,
constraint fk_penyakit
	foreign key ("penyakit_id")
	references penyakit ("id_penyakit")
	on delete cascade,
constraint fk_jenis_obat
	foreign key ("jenis_id")
	references jenis_obat ("id_jenis")
	on delete cascade
);

create table faskes (
id_faskes serial primary key,
nama_faskes varchar (256),
alamat varchar (256),
kota varchar (256),
no_telfon numeric,
website varchar (256), 
jam_operasional varchar (256)
);

create table kalori_makanan (
id_makanan serial primary key,
nama_makanan varchar (256),
kategori varchar (256),
kandungan int
);

create table jenis_profil (
id_jenis_profil serial primary key,
nama_jenis_profil text
);

create table profil (
id_profil serial primary key,
nama text,
email varchar (256),
password varchar (256),
alamat varchar (256),
kota varchar (256),
negara varchar (256),
no_telfon numeric,
id_jenis_profil serial,
constraint fk_jenis_profil
	foreign key (id_jenis_profil)
	references jenis_profil (id_jenis_profil)
	on delete cascade
);

select * from kalori_makanan

insert into faskes(nama_faskes, alamat, kota, no_telfon, website, jam_operasional)
values ('RSU Kaliwates Jember', 'Jl. Diah Pitaloka No.4a, Kaliwates Kidul, Kaliwates, Kec. Kaliwates 68131', 'Jember', 0331483505, 'rsukaliwatesjember.com', '24 jam'),
		('RS Perkebunan Jember Klinik', 'Jalan Bedadung No. 2 , Jember Lor, Kec. Patrang 68118', 'Jember', 0331485912, 'jemberklinik.co.id', '24 jam'),
		('RSUD dr.Soebandi Jember', 'Jl. Dr. Soebandi No. 124 Patrang 68111 ', 'Jember', 0331487111, 'rsuddrsoebandi.jatimprov.go.id', '24 jam'),
		('Siloam Hospitals Jember', 'Jl. Gajah Mada No. 12 Kaliwates 68128', 'Jember', 0331484911, ', siloamhospitals.com', '24 jam'),
		('RS Utama Husada Jember', ', Jl. Letjen Suprapto No. 44, Jember Kidul, Kaliwates 68131', 'Jember', 0331484948, 'rsutamahusada.co.id', '24 jam'),
		('RS Bina Sehat Jember', 'Jl. Jayanegara No. 55, Krajan Timur, Patrang 68121', 'Jember', 0331487171, 'rsbinasehat.com', '24 jam'),
		('RS Yasmin Banyuwangi', 'Jl. Letkol Istiqlah No. 80-84, Singonegaran, Kec. Banyuwangi 68418', 'Banyuwangi', 0333424671, 'yasminhospital.com', '24 jam'),
		('RSI Fatimah Banyuwangi', 'Jl. Jenderal Ahmad Yani No.78, Tukangkayu, Kec. Banyuwangi 68416', 'Banyuwangi', 0333424111, 'rsukaliwatesjember.com', '24 jam'),
		('RS Abdhi Famili Banyuwangi', 'Jl. KH. Moh. Ikrom Wringinrejo, kec. Gambiran 68425', 'Banyuwangi', 0333842219, 'rsifatimahbwi.com', '24 jam'),
		('RS Bhakti Husada Krikilan Glenmore Banyuwangi', 'Jl. rs Bhakti Husada No.11 68466', 'Banyuwangi', 0333821118, 'rsabdhifamili.com', '24 jam'),
		('Rumah Sakit Bhayangkara Bondowoso', 'Jalan Jend. Pol. S. Judhodiharjo No.12, Purbosari, Kotakulon, Kec. Bondowoso, Badean 68219', 'Bondowoso', 0332433431, 'rsubhaktihusada.com', '24 jam'),
		('RSUD dr. H. Koesnadi Bondowoso', 'Jl. Kapten Jl. Piere Tendean No.3, Badean 68219', 'Bondowoso', 0332421263, 'bhayangkarabondowoso.com', '24 jam'),
		('Rumah Sakit Mitra Medika', 'Jl. HOS Cokroaminoto No.98, Kademangan Kulon, Kademangan, Kec. Bondowoso 68213', 'Bondowoso', 0332421981, 'rsu-drkoesnadi.go.id', '24 jam'),
		('RSNU Bondowoso', 'Jl. Raya Situbondo, Tangsil Selatan, Traktakan, Kec. Wonosari 68213', 'Bondowoso', 081359811770, 'mitramedikabondowoso.com', '08.00 - 20.00'),
		('Rumah Sakit dr. Abdoer Rahem', 'Jl. Anggrek No.68, Patokan Utara, Patokan, Kec. Situbondo 68351', 'Situbondo', 0338673293, 'rsnubondowoso.com', '24 jam'),
		('Rumah Sakit Elizabeth', 'Jl. WR. Supratman No.2, Mulyautama, Patokan, Kec. Situbondo 68351', 'Situbondo', 0338671174, 'rsar.situbondokab.go.id', '24 jam'),
		('Rumah Sakit Mitra Sehat Situbondo', 'Curah Jeru, RT.02/RW.11, Panji, Curahjeru Timur, Curah Jeru, Kec. Panji 68321', 'Situbondo', 082333282112, 'rsmitrasehatsitubondo.com', '24 jam');
		
insert into kalori_makanan(nama_makanan, kategori, kandungan)
values ('apel', 'buah', 104),
		('anggur', 'buah', 104),
		('jeruk', 'buah', 47 ),
		('pisang', 'buah', 105),
		('jambu biji', 'buah''buah', 136),
		('pepaya', 'buah', 43),
		('kurma', 'buah',  282),
		('stroberi', 'buah', 32),
		('alpukat', 'buah',  160),
		('kiwi', 'buah', 61),
		('melon', 'buah', 34),
		('bayam', 'sayur', 23),
		('brokoli', 'sayur', 34),
		('wortel', 'sayur', 41),
		('tomat', 'sayur', 18),
		('kubis', 'sayur', 25),
		('selada', 'sayur', 15),
		('kangkung', 'sayur', 20),
		('terong', 'sayur', 25),
		('sawi', 'sayur', 24),
		('kol', 'sayur', 25),
		('kacang hijau', 'sayur', 105),
		('labu', 'sayur', 26),
		('kacang polong', 'sayur', 81),
		('daging sapi', 'lauk pauk', 150),
		('telur', 'lauk pauk', 155),
		('salmon', 'lauk pauk', 208),
		('tahu', 'lauk pauk', 76),
		('tempe', 'lauk pauk', 193),
		('ikan', 'lauk pauk', 100),
		('udang', 'lauk pauk', 85),
		('nasi putih', 'makanan pokok', 175),
		('kentang', 'makanan pokok', 86),
		('jagung', 'makanan pokok', 96),
		('singkong', 'makanan pokok', 160),
		('gandum', 'makanan pokok', 340),
		('sagu', 'makanan pokok', 355),
		('nasi merah', 'makanan pokok', 111),
		('susu sapi', 'susu', 150),
		('susu kedelai', 'susu', 80),
		('susu kambing', 'susu', 160),
		('susu almond', 'susu', 30)
		
INSERT INTO obat (nama_obat, fungsi, dosis, penyakit_id, jenis_id)
VALUES 
    ('Albumin', 'menangani gangguan aliran darah parah (syok) akibat cedera atau luka bakar berat', '25 gr/hari', 1, 1),
    ('Amoxcilin', 'mengatasi infeksi bakteri, seperti sakit tenggorokan, diare, pneumonia dan infeksi telinga', '250-500 mg/hari', 1, 1),
    ('Beta Karoten', 'mengatasi kekurangan vitamin A dan sebagai sumber antioksidan', '30-300 mg/hari', 1, 2),
    ('Carbidu', 'mengatasi peradangan dan reaksi alergi yang berupa gatal-gatal di kulit', '0.5-9 mg/hari', 2, 2),
    ('Dexametashon', 'meredakan peradangan, penyakit autoimun, atau radang sendi', '0,5-0,9 mg/hari', 3, 3),
    ('Epexol', 'mengencerkan lendir atau dahak', '30mg/hari', 3, 4),
    ('Fluoxetin', 'mengatasi depresi, gangguan obsesif kompulsif (OCD), gangguan disforik pramenstruasi, bulimia', '20- 40 mg/hari', 4, 5),
    ('Genalsik', 'mengurangi produksi asam urat dalam tubuh', '40 mg/hari', 5, 6),
    ('Kaditic', 'meredakan nyeri dan peradangan akibat radang sendi (arthritis), atau nyeri pascaoperasi', '50mg', 6, 7),
    ('Lecithin', 'menurunkan kadar kolesterol darah, serta menjaga kesehatan liver dan otak', '3–30 gram/hari', 7, 7);

INSERT INTO jenis_profil (nama_jenis_profil)
VALUES 
    ('Admin'),
    ('User');

INSERT INTO profil (nama, email, password, alamat, kota, negara, no_telfon, id_jenis_profil) 
VALUES
    ('Vica Nadya', 'vicanadya02@email.com', 'vica3002', 'Jl. Raya No. 456', 'Jakarta', 'Indonesia', 081234567891, 1),
    ('Catherine Csianee Juliana', 'catherinecsi04@gmail.com', 'cthrn3004', '123 Gangnam-daero', 'Seoul', 'Korea Selatan', 081234567891, 1),
    ('Nandini Putri Hanifa Jannah', 'nandiniputri24@gmail.com', 'nanan3024', 'Rue de la Paix 8', 'Paris', 'Perancis', 081234567892, 2),
    ('Ahnaf Alfarez S', 'ahnafalfarez36@gmail.com', 'anap3036', 'Gran Via', 'Dubai', 'Uni Emirat Arab', 081234567893, 2),
    ('Rifqi Adrianto', 'rifqiadrianto42@gmail.com', 'rifqi3042', 'Piazza del Duomo', 'Milan', 'Italia', 081234567894, 1),
    ('Luciano Cezar Budi Prasetio', 'lucianocezar60@gmail.com', 'pras3060', 'Unter den Linden 5', 'Berlin', 'Jerman', 081234567895, 2),
    ('Zakha Aditya Hadiansyah', 'zakhaaditya61@gmail.com', 'jaka3061', '123 Jalan Tun Razak', 'Kuala Lumpur', 'Malaysia', 081234567896, 1),
    ('Afiyah Deni', 'afiyahdeni64@gmail.com', 'fiya3064', '123 Main St', 'New Delhi', 'India', 081234567897, 1),
    ('Aldi Ahmad Dani', 'aldi ahmad74@gmail.com', 'aldi3074', '123 Main St', 'New York', 'Amerika Serikat', 081234567898, 2),
    ('Deies Ade Irawan', 'deviesade79@gmail.com', 'depis3079', 'Via Roma 10', 'Roma', 'Italia', 081234567899, 1),
    ('Chindika Febryola', 'chindikafeb84@gmail.com', 'sindika3084', 'Jl. Ahmad Yani No. 10', 'Bandung', 'Indonesia', 081234567800, 1),
    ('Alfoncio Paji Shogen', 'alfonciopaji95@gmail.com', 'cio3095', 'Jl. Darmo Baru No. 10', 'Surabaya', 'Indonesia', 081234567801, 2),
    ('M Rafi Kurniawan', 'rafikurniawan98@gmail.com', 'rafi3098', '456 Jalan Ampang', 'Kuala Lumpur', 'Malaysia', 081234567802, 1);

INSERT INTO penyakit(nama_penyakit) 
VALUES
('Influenza'),
('Diabetes Mellitus'),
('Hipertensi'),
('Tuberkulosis'),
('Malaria'),
('Demam Berdarah'),
('COVID-19'),
('Pneumonia'),
('Hepatitis B'),
('HIV/AIDS'),
('Kanker Paru-paru'),
('Gagal Jantung'),
('Stroke'),
('Ginjal Kronis'),
('Asma'),
('Bronkitis'),
('Osteoporosis'),
('Anemia'),
('Tifus'),
('Kolera')

insert into jenis_obat(jenis)
values ('obat bebas'),
		('obat bebas terbatas'),
		('obat keras'),
		('obat golongan narkotika'),
		('obat fitofarmaka'),
		('obat herbal terstandar'),
		('obat herbal')

select * from profil

insert into artikel(judul, sumber)
values ('Posyandu Sebagai Pilar Utama Penyediaan Kesehatan Ibu Dan Anak Di Masyarakat', 'https://www.kompasiana.com/muhammaddahron2351/664ad19dde948f64081050d2/posyandu-sebagai-pilar-utama-penyediaan-kesehatan-ibu-dan-anak-di-masyarakat'),
		('Menghitung Berat Badan Ideal Dan Berbagai Masalah Kesehatan Akibat Berat Badan', 'https://www.anlene.com/id/ms/menghitung-berat-badan-ideal-dan-berbagai-masalah-kesehatan-akibat-berat-badan.html'),
		('Memahami Siklus Menstruasi Yang Dialami Oleh Para Wanita', 'https://www.gramedia.com/literasi/siklus-menstruasi/'),
		('Kalender Kehamilan Cina Untuk Menentukan Jenis Kelamin Bayi', 'https://www.prenagen.com/id/kalender-kehamilan-cina'),
		('Diabetes Tak Pandang Usia : Ancaman Mengintai Semua Kalangan', 'https://www.kompasiana.com/nurfadiyahputri9079/664af8f4de948f0939317022/diabetes-tak-pandang-usia-ancaman-mengintai-semua-kalangan'),
		('⁠Hati-Hati! Kesepian Risiko Penyakit Parkinson', 'https://www.kompasiana.com/ichanuraktavia0426/664202c0de948f2bb82da022/hati-hati-kesepian-resiko-penyakit-parkinson'),
		('Waspada penyakit kolesterol di usia remaja!', 'https://www.kompasiana.com/talitha16366/66405fa3c57afb467f5dbb52/waspada-penyakit-kolesterol-di-usia-remaja'),
		('Waspada Gagal Ginjal Akut Bisa Terjadi Di Semua Usia', 'https://primayahospital.com/penyakit-dalam/gagal-ginjal-akut/'),
		('Penyebab Nyeri Perut Sebelah Kiri Yang Tidak Boleh Disepelekan', 'https://primayahospital.com/penyakit-dalam/nyeri-perut-sebelah-kiri/'),
		('Apa Itu Poliuria? Kenali Penyebab Dan Cara Mengatasinya', 'https://primayahospital.com/penyakit-dalam/poliuria/'),
		('EGD: Prosedur Medis Evaluasi Kondisi Saluran Pencernaan Atas', 'https://primayahospital.com/penyakit-dalam/saluran-pencernaan/'),
		('Mulut Kering Padahal Sudah Minum Banyak? Yuk Ketahui Penyebabnya', 'https://primayahospital.com/penyakit-dalam/mulut-kering/'),
		('Gastritis: Gejala, Mencegah dan Mengobati', 'https://primayahospital.com/penyakit-dalam/gastritis/'),
		('Mengenal Penyebab Penyakit Hepatitis', 'https://aido.id/health-articles/penyebab-penyakit-hepatitis/detail'),
		('Taxol Sebagai Anti Kanker', 'https://aido.id/health-articles/taxol-sebagai-anti-kanker/detail');
		
ALTER TABLE artikel ALTER COLUMN id_artikel TYPE varchar (8);
		
select * from obat