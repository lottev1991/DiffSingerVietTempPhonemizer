# DiffSinger Temporary Vietnamese Phonemizer
Simple makeshift Vietnamese phonemizer for DiffSinger voicebanks. There's nothing fancy about this, no G2P or anything, only custom dict support.
I will not merge this upstream, since in my opinion, an in-built Vietnamese phonemizer would need a proper G2P dictionary.
Feel free to ship this with your own voicebanks, along with the dsdict I made; just credit me for making them.
You're also free to edit the dsdict to fit your own phoneme system.
You don't even have to use the dictionary for DiffSinger, you can also use it for UTAU etc, I really don't care.

## How to install the phonemizer
### Method #1
Drag-and-drop the .dll file (can be found in the Releases tab on the right) onto the OpenUtau program. It'll be automatically installed.

### Method #2
Copy the .dll file (in the Releases tab on the right) over to the Plugins folder inside the OpenUtau installation folder. If this folder doesn't exist, make it.

## How to install/use the dsdict
- Copy over the ``dsdur`` folder into your voicebank's folder (or just copy the ``dsdict-vi.yaml`` file alone).
- Now you can use it with the Vietnamese phonemizer.

## Phoneme set
This is a rough overview of the (largely improvised) default phonetic system of the dictionary. I can't guarantee that this covers everything in every context, but it should give a rough idea.

| Grapheme(s)  | Phoneme(s) |
| ------------- | ------------- |
| __a, ă__  | ``a`` |
| __â, ơ__  | ``A`` (long), ``AX`` (short) |
| __b__  | ``b`` |
| __c, k, q__ | ``k`` (beginning), ``K`` (end) |
| __ch__  | ``ch`` (beginning), ``K`` (end) |
| __d, gi-, r__  | ``z`` |
| __đ__  | ``d`` |
| __e__  | ``e`` |
| __ê__  | ``E`` (long), ``AX`` (short) |
| __f, ph__  | ``f`` |
| __g, gh__  | ``g`` |
| __h__  | ``h`` |
| __i, y__  | ``i`` (long), ``y`` (short) |
| __kh__  | ``kh`` |
| __l__  | ``l`` |
| __m__  | ``m`` (beginning), ``M`` (end) |
| __n__  | ``n`` (beginning), ``N`` (end) |
| __nh__  | ``nh`` (beginning), ``NG`` (end) |
| __ng, ngh__  | ``ng`` (beginning), ``NG`` (end) |
| __o__  | ``o`` (long), ``w`` (short) |
| __ô__  | ``O`` |
| __p__  | ``p`` (beginning), ``P`` (end) |
| __s, x__  | ``s`` |
| __t__  | ``t`` (beginning), ``T`` (end) |
| __th__  | ``th`` |
| __u__  | ``u`` (long), ``w`` (short) |
| __ư__  | ``U`` |
| __v__  | ``v`` |
| __none__  | ``q`` (glottal stop before vowels and ``w``) |

If there are any inaccuracies in the dict, feel free to open an issue in the Issues tab above, or you can submit a pull request with corrections.

---

Dictionary adapted from [Vi_G2P](https://github.com/v-nhandt21/Vi_G2P).