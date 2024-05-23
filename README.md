# BallAvoid
![image](https://github.com/bfcat46/ball_avoid/assets/54877137/029de790-d77e-4aea-a264-e2169f680c4e)


### 게임명 : 공피하기
### 개발 환경	: Unity 2022.3.2f1
### 개발 기간	: 2024/05/16 ~ 2024/05/24


## 팀원 

![image](https://github.com/bfcat46/ball_avoid/assets/54877137/7572dd79-ad73-46fb-91f8-d8d8e43dce3e)




## 게임소개

![image](https://github.com/bfcat46/ball_avoid/assets/54877137/30e8ccee-7b5f-49b4-8635-359ce6fdfff5)

![image](https://github.com/bfcat46/ball_avoid/assets/54877137/5bda50ed-7d3d-4e18-be62-f4318577ae5c)


### 캐릭터 이동 : A D

### 게임 기능
## 스크립트 별 설명
|기능 이름| 기능 설명 | 스크립트 |
|:------:|:---:|:---:|
|OnSceneLoaded()|씬이 로드될 대마다 호출되며, 설정 씬에서는 슬라이더를 표시하고 이벤트를 등록하고, 다른 씬에서는 슬라이더를 숨기는 기능을 한다.|AudioManager|
|SetVolume()|볼륨 값을 0~1 사이로 제한|AudioManager|
|MakeBall()|새로운 공을 생성합니다. InvokeRepeating에 의해 일정 시간 간격으로 호출됩니다.|GameManager|
|SpawnApple()|랜덤한 위치에 사과를 생성합니다. InvokeRepeating에 의해 일정 시간 간격으로 호출됩니다.|GameManager|
|GameOver()|게임 오버 시 호출됩니다. 게임이 더 이상 진행 중이 아니도록 설정하고, 게임 오버 모달 창을 활성화합니다. 타이머 텍스트를 비웁니다. 현재 점수가 최고 점수보다 높다면 최고 점수를 갱신합니다. 현재 점수와 최고 점수를 결과 텍스트에 표시합니다. 게임을 일시정지합니다.|GameManager|
|Timer()|게임 시관을 관리하는 코루틴 이다, 게임 시간이 설정된 분으로 초기화됩니다.|TimeManager|
|DontDestroyOnLoad(gameObject)|씬 전환 시에도 파ㅗ기 되지 않도록 설정|DataManager|
|OnCollisionEnter2D|볼이 다른 오브젝트 충돌할 때 호출됩니다. 충돌시 Gronud와 Player 인 경우에 따라서 결과값을 다르게 한다.|Ball|
|ActivateShield()|방패를 활성화 하고 ShieldTimer 코루틴을 시작하여 방패 지속 시간 동안 방패를 활성화합니다.|Player|
|ShieldTimer()|10초동안 방패를 활성화, 시간이 지나면 방패를 비활성화|Player|
|HandleVolumeChange(float volume)|OnVolumeChange 이벤트를 발생시켜서 등록된 모든 이벤트에 변경된 불륨 값을 전달합니다. |VolumeSlider|
|ChoiceCharacter(int num)|선택한 캐릭터 번호에 해당하는 캐릭터 이미지를SelectedCharacter에 설정합니다.|IntroUI|
## 파일 구조 및 와이어프레임
![image](https://github.com/bfcat46/ball_avoid/assets/54877137/d3492073-4a19-4894-882d-75c6d1efd2c2)
![image](https://github.com/bfcat46/ball_avoid/assets/54877137/93f4a3a8-2a59-45aa-89f7-507af5490e7e)
![image](https://github.com/bfcat46/ball_avoid/assets/54877137/59619e28-2056-426a-9b7c-8bd0844d17bc)
![image](https://github.com/bfcat46/ball_avoid/assets/54877137/24b0c063-bef9-41dc-810f-254475258977)


## 팀이 겪은 트러블 슈팅
![image](https://github.com/bfcat46/ball_avoid/assets/54877137/c5bb0b23-354d-4b65-9b98-c54a1f96884a)



## 링크
[영상](https://www.notion.so/teamsparta/5-30b70d35a0544dda849b0b5cf2b0760e?pvs=4#4a274909c3a04f239ceb743a878cec1e)
[노션](https://www.notion.so/teamsparta/5-30b70d35a0544dda849b0b5cf2b0760e/)
