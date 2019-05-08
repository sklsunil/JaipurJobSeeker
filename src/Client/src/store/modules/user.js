import { profileService } from '../../services/profile.service';
import Vue from 'vue';
const state = { profile: {}, status: '' };
const getters = {
    profile: (userState) => userState.profile,
};
const actions = {
    userRequest: ({ commit, dispatch }) => {
        commit('userRequest');
        profileService.get()
            .subscribe((result) => {
            commit('userSuccess', result);
        }, (errors) => {
            commit('userError');
            dispatch('auth/authLogout', null, { root: true });
        });
    },
};
const mutations = {
    userRequest: (userState) => {
        userState.status = 'attempting request for user profile data';
    },
    userSuccess: (userState, userResp) => {
        userState.status = 'success';
        Vue.set(userState, 'profile', userResp);
    },
    userError: (userState) => {
        userState.status = 'error';
    },
};
export default {
    state,
    getters,
    actions,
    mutations,
};
//# sourceMappingURL=user.js.map