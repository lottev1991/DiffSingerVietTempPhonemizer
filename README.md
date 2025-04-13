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
- Copy over either of the ``dsdur`` folder into your voicebank's folder (or just copy the ``dsdict-vi.yaml`` file alone). You can find those in the "Multidict" and "Single dict" folders; which one you need depends on if your model is multidict or not.
- Now you can use it with the Vietnamese phonemizer.

## Phoneme set
The multidict language code is `vi`.

This is a rough overview of the (largely improvised) default phonetic system of the dictionary. I can't guarantee that this covers everything in every context, but it should give a rough idea.

| Grapheme(s)  | Phoneme(s) |
| ------------- | ------------- |
| _a, ă_  | ``a`` |
| _â, ơ_  | ``A`` (long), ``AX`` (short) |
| _b_  | ``b`` |
| _c, k, q_ | ``k`` (beginning), ``K`` (end) |
| _ch_  | ``ch`` (beginning), ``K`` (end) |
| _d, gi-, r_  | ``z`` |
| _đ_  | ``d`` |
| _e_  | ``e`` |
| _ê_  | ``E`` (long), ``AX`` (short) |
| _f, ph_  | ``f`` |
| _g, gh_  | ``g`` |
| _h_  | ``h`` |
| _i, y_  | ``i`` (long), ``y`` (short) |
| _kh_  | ``kh`` |
| _l_  | ``l`` |
| _m_  | ``m`` (beginning), ``M`` (end) |
| _n_  | ``n`` (beginning), ``N`` (end) |
| _nh_  | ``nh`` (beginning), ``NG`` (end) |
| _ng, ngh_  | ``ng`` (beginning), ``NG`` (end) |
| _o_  | ``o`` (long), ``w`` (short) |
| _ô_  | ``O`` |
| _p_  | ``p`` (beginning), ``P`` (end) |
| _s, x_  | ``s`` |
| _t_  | ``t`` (beginning), ``T`` (end) |
| _th_  | ``th`` |
| _tr_  | ``ch`` |
| _u_  | ``u`` (long), ``w`` (short) |
| _ư_  | ``U`` |
| _v_  | ``v`` |
| _none_  | ``GS`` (glottal stop before vowels and ``w``) |

If there are any inaccuracies in the dict, feel free to open an issue in the Issues tab above, or you can submit a pull request with corrections.

---

Dictionary adapted from [Vi_G2P](https://github.com/v-nhandt21/Vi_G2P).
